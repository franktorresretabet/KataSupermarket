# Shopping Cart - Supermarket

## Define un tipo Money

- ¿Entero de céntimos? ¿Decimal con escala fija?
- ¿Incluyes divisa?
- Define un modelo de Price / PricingRule

## Algunos ejemplos a considerar:

UnitPrice → precio normal por unidad.

BulkPrice → “3 por 1 €”, “10 por 5 €”.

WeightPrice → precio por kg / g.

MultiBuyOffer → “compra 2 y el 3º gratis”, “2ª unidad al 50%”.

PercentageDiscount → -10%, etc.

## Simula un carrito de compra

- Distintos productos con diferentes esquemas de precios.
- Calcula el total, desglosando cómo se ha llegado a cada precio.

## Validaciones de ejemplo
1. UnitPrice 3x0.50 => 1.50
2. Bulk 8 con regla 3x1.00 y unit 0.40 => 2.80
3. Weight 1.250kg a 2.30 => 2.875 (definir redondeo esperado)
4. MultiBuy 7 con B2G1 y unit 1.20 => 6.00
5. Discount 2x5.00 con 10% => 9.00
6. Carrito mixto suma subtotales de cada línea con desglose completo

## Arquitectura
Política por producto (simple y clara)

## Modelo conceptual recomendado

### Money
Valor monetario con reglas de redondeo y operaciones seguras.

Evita cálculos directos con decimal repartidos por todo el dominio.

### CartLine
Producto

Cantidad (unidad o peso)

Unidad de medida (Unit, Kg, Gram)

Política asignada al producto (o referencia a ella)

### PricingPolicy
- Contrato común: calcula precio de una línea y devuelve detalle.

- Implementaciones:

    > UnitPricePolicy

    > BulkPricePolicy

    > WeightPricePolicy

    > MultiBuyPolicy

    > PercentageDiscountPolicy

### PricingResult
Subtotal de línea

Lista de pasos de cálculo (explicables)

Metadatos opcionales (unidades gratis, packs aplicados, etc.)

### CartPricingSummary
Total carrito

Resultados por línea

Total descuentos aplicados (si quieres visibilidad adicional)