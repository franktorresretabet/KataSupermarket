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