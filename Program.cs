string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach(string myString in myStrings){
    int periodLocation = myString.IndexOf(".");

    string currentString = myString;

    while(periodLocation != -1){
        string sentence = currentString.Substring(0, periodLocation).Trim();

        Console.WriteLine(sentence);

        currentString = currentString.Remove(0, periodLocation + 1);

        periodLocation = currentString.IndexOf(".");
    }

    if(currentString.Length > 1){
        Console.WriteLine(currentString.Trim());
    }
}