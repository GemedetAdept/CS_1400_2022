// Pluto || CS 1050 2022-08-29
// Print strings according to user input

bool loop = true; // Boolean value to establish while-loop

while (loop == true) {

	Console.WriteLine("[0] = \"Hello, world!\"");
	Console.WriteLine("[1] = \"Foo, bar!\"\n");
	Console.Write("Input option > ");

	var inputValue = Console.ReadLine();
	int inputRectif = Convert.ToInt32(inputValue); // Convert string number to integer

	Console.Write("\n> ");

	if (inputRectif == 0) {
		Console.WriteLine("Hello, world!");
	}

	if (inputRectif == 1) {
		Console.WriteLine("Foo, bar!");
	}

	// Reset loop with [Enter]
	var reLoop = Console.ReadLine();

	// End loop by setting "loop" boolean to False
	if (reLoop == "Exit") {
		loop = false;
	}

	Console.Clear();
	continue;

}

Environment.Exit(0); // Exit program when loop ends
