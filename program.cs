//Print the users backstory
Console.WriteLine("Greetings, welcome to Aetherium, a robust and hevaily instustrialize Martian prefixure.");
Console.WriteLine("You are a talented and well decorated robotocist. It's year 2060, and humanity has successfully colonized Mars thanks to advancements in galactic travel and technological innovation.");
Console.WriteLine("You reside in Mars, and you're employed by EastCorp, a powerful and influential technological conglomerate specialing in robotics and artificial general intelligence.");
Console.WriteLine("You're situated in your lab. You decide to look around.");
Console.WriteLine("The lab estlmanates an atmosphere of technological marvels and scientific ingenuity. Bathed in soft, artificial light, the room exudes an aura of meticulous order and functionality. Sleek, metallic surfaces, adorned with holographic displays and intricate circuitry, reflect the hum of machinery and the soft glow of data streams.");
Console.WriteLine("Would you like to view your dashboard or exit to the Central Control Center?");

//Prompt user choice
Console.Write(">");
string roomChoice - Console.ReadLine();

//Ask player which room they want to go to
if(roomChoice == "view your dashboard")
{
    Console.WriteLine("You chose to view your dashboard.");
    Console.WriteLine("You approach a sleek, holographic dashboard showcasing an index of tasks and priorities. One in particular stands out. The subject line in bold ominous letters reads: 'High-Risk Alert: Malfunctioning Robots.");
    Console.WriteLine("Would you like to open the email?");

    //Prompt user choice
    Console.Write("> ");
    string emailChoice = Console.ReadLine();

    if(emailChoice = "Yes")
    {
        Console.WriteLine("You open the email and contents materialize before you in a cascading holographic projection. The message reveals a detailed report, outlining the distressing news of robots within EastCorp's facilities experiencing unexpected malfunctions, exhibiting erratic behavior, and posing potential threats to both human employees and the delicate balance of operations.");
        Console.WriteLine("The email omits the specifics, requiring a meeting to discuss pressing issues.");
        Console.WriteLine("All robotocists, software, hardware, systems engineers and researches are required to report to AI Ethics and Compliance office.");
    }
    else if("No")
    {
        Console.WriteLine("You decided to not check your email.");

    }
    else
    {
        Console.WriteLine("Invalid choice. Please select yes or no.");
    }
}
else if(roomChoice == "Central Control Center")
{
    Console.WriteLine("You decided to go to the Central Control Center.");
    Console.WriteLine("The normally oranized Central Control Room is in complete disarray and chaos. The computer screens flickering with obscure error messages casting an eerie glow on the panicked expressions of the technicians frantically attempting to restore order.");
    Console.WriteLine("Would you like to speak to the technicians?");

    //Prompt user choice
    Console.Write("> ");
    string techniciansChoice = Console.ReadLine();
    
    if(techniciansChoice == "yes")
    {
        Console.WriteLine("You tap the younger technician in the shoulder.");
    }
    else if(techniciansChoice == "no")
    {
         Console.WriteLine("You decide not to disturb the technicians.");
          Console.WriteLine("You turn arounde back towards the direction of your lab.");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please select yes or no.");
    }


}
else
{
     Console.WriteLine("Invalid choice. Please select view your dashboard or Central Control Center.");
}


