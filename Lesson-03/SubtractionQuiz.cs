Random random = new();
int a = random.Next(1, 10);
int b = random.Next(1, 10);
if (a < b) (a, b) = (b, a);