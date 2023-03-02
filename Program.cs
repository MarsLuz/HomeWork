class Program
    {
        static void Main(string[] args)
        {
            string organization;
            int password;

            Console.Write("Input your password : ");
            password = int.Parse(Console.ReadLine());

            Console.Write("Input your Organization : ");

            organization = Console.ReadLine();

            if (organization == "CIA")
            {
                bool con1 = false, con2 = false, con3 = false; // set 3 boolean condition if 3 of them are true password is correct
                int cia1, cia2, cia3; // set 3 int for check each digit value of condition
                cia1 = password % 10; // modulation to get first digit
                if (cia1 % 3 == 0) // first digit is divide by 3 or not 
                {
                    con1 = true;
                    //Console.WriteLine("con1 true");
                    cia2 = password / 10000; // divide by 10000 to check 5th digit
                    if (cia2 % 10 !=  1 && cia2 %10 != 3 && cia2 %10 != 5) // check if it can be divide by 1 3 5 or not
                    {
                       //Console.WriteLine("con2 true");
                        con2 = true;
                        cia3 = password / 1000; // divide by 1000 to check 4th digit
                        if (cia3 % 10 >= 6 && cia3 % 10 != 8) // check if it more than 6 but not 8
                        {
                            //Console.WriteLine("con3 true");
                            con3 = true;
                        }
                    }
                }
                if (con1 && con2 && con3 == true)
                {
                    Console.WriteLine("Password correct");
                }
                else
                {
                    Console.WriteLine("Password Incorrect");
                }
            }
            else if (organization == "FBI")
            {
                bool con1 = false, con2 = false, con3 = false; // set 3 boolean condition if 3 of them are true password is correct
                int fbi1, fbi2, fbi3;  // set 3 int for check each digit value of condition

                fbi1 = password / 100000; // divided by 100000 to get first digit of password
                if (fbi1 >= 4 && fbi1 <= 7) // check if password in 4-7 range
                {
                    con1 = true;
                    //Console.WriteLine("con1 true");
                    fbi2 = password / 100;  // divided by 10000 to get 4th digit of password
                    if (fbi2 % 2 == 0 && fbi2 != 6) // check if it even number but not equal to 6
                    {
                        con2 = true;
                        fbi3 = password / 10000; // divided by 10000 to get 2nd digit of password
                        //Console.WriteLine("con2 true");

                        if (fbi3 % 2 == 1 || fbi3 == 1) // check if it odd number so mod by 2 equal to 1 but add another condition incase digit is 1
                        {
                            con3 = true;
                            //Console.WriteLine("con3 true");
                        }
                    }
                }

                if (con1 && con2 && con3 == true)
                {
                    Console.WriteLine("Password correct");
                }
                else
                {
                    Console.WriteLine("Password Incorrect");
                }
            }
            else if (organization == "NSA")
            {
                bool con1 = false, con2 = false, con3 = false; // set 3 boolean condition if 3 of them are true password is correct
                int nsa1, nsa2, nsa3; // set 3 int for check each digit value of condition

                nsa1 = password % 10;
                if (nsa1 == 1 || nsa1 == 2 || nsa1 == 3 || nsa1 == 5 || nsa1 == 6) // check if the first condtion is 30 match factor which is 1,2,3,5,6
                {

                    con1 = true;
                    //Console.WriteLine("con1 true");
                    nsa2 = password / 100;
                    if (nsa2 % 10 == 3 || nsa2 % 10 == 9) // check if 2nd condtion divided by 3 but not 6 , so it's just 3 and 9
                    {
                        con2 = true;
                        //Console.WriteLine("con2 true");

                        //check if 3rd condtion contain 7 or not 
                        // https://stackoverflow.com/questions/4977456/how-to-check-if-a-int-var-contains-a-specific-number (i copy from this one)
                        while (password > 0)
                        {
                            nsa3 = password % 10;
                            //Console.WriteLine(nsa3);
                            password = password / 10;
                            //Console.WriteLine(password);

                            if (nsa3 == 7)
                            {
                                //Console.WriteLine("con3 true");
                                con3 = true;
                                break;
                            }
                        }

                    }
                }

                if (con1 && con2 && con3 == true) 
                {
                    Console.WriteLine("Password correct");
                }
                else
                {
                    Console.WriteLine("Password Incorrect");
                }
            }
            else // if input organization not 3 of them set invalid value
            {
                Console.WriteLine("Invalid Organization");

            }

        }
    }