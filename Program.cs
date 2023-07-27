using System.Text.RegularExpressions;
namespace ESLang{
    class Lang{
        static char[] alphabets = {'W', 'A','S', 'D', 'w', 'a', 's', 'd', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '_', '*', '#', '!'};
        static void Main(string[] args){
            string message = "Welcome to ES-Lang";
            
            Console.WriteLine("{0}", message);
            var name = Console.ReadLine();
            Console.WriteLine(Lang.validatePassword(name));
            
        }

        public bool validate(){
            return true;
        }

        public static bool validateAplabets(string _ref){
            List<char> invalidAplbabets = new List<char>();
            foreach(char _char in _ref){
                if (!Lang.alphabets.Contains(_char)){
                    invalidAplbabets.Add(_char);
                }        
            }

            if (invalidAplbabets.Count < 1) return true;
                else {
                    Console.WriteLine("Invalid Alphbets Detetced >>> {0}\n", string.Join(", ", invalidAplbabets.ToArray()));
                    Lang.displayAlphabets();
                    
                }

                return false;

        }

        public static bool validatePassword(string _password){
            //Password Must Contain AT LEAST 1 Uppercase character,
            // 1 symbol,
            // 1 Number
            string pattern = @"(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[*#_!])[!-~]{8,}$";
            return (Regex.IsMatch(_password, pattern));
        }

        public static bool validateUserame(string username){
            
        }


        public static void displayAlphabets(){
            Console.WriteLine("Valid Alphabets >>> {0}", string.Join(", ", Lang.alphabets));
        }

        public struct Credentials
        {
            public Credentials(string _username, string _password){
                username = _username;
                password = _password;
            }
            public string username;
            public string password;
        }
    }
}