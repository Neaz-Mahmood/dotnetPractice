string card = "1234567890123456";
bool isValid = ValidateCard.IsValid(card);

if (isValid)
{
    Console.WriteLine(card + " is valid");
}
else
{
    Console.WriteLine(card + " is invalid");
}