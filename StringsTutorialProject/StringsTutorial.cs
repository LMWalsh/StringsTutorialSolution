using System;
using System.Collections.Generic;
using System.Text;

namespace StringsTutorialProject {
    class StringsTutorial {

        public string Firstname = "Ben";
        public string Lastname = "Walsh";

        public StringsTutorial() {
            Firstname = "Ben";
            Lastname = "Walsh";
            }

        public StringsTutorial(string firstname, string lastname) {
            Firstname = firstname;
            Lastname = lastname; 
            }

        public string Fullname() {

            //var Firstname = "Laura";
            //var Lastname = "Walsh";

            // var fullname = Firstname + " " + Lastname;
            var fullname = $" {Lastname}, {Firstname}";

            return fullname;
            }
        public string Fullname2() { 
      //var Firstname = "Laura";
      //  var Lastname = "Walsh";
        var fullname = $" {Firstname} {Lastname}";
        return fullname;
        }
    }
    }
