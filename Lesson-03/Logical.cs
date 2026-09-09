using System.Text.Encodings.Web;

int age = 20; bool hasId = false;
bool isMember = true; bool hasCoupon = false; bool isClosed = true;
bool canEnter = age >= 18 && hasId; //If both are True
bool discount = isMember || hasCoupon; //If either of them is true it is true
bool open = !isClosed; //If its not true its false
