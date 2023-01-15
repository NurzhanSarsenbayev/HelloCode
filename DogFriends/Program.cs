double FirstFriendSpeed = 1;
double SecondFriendSpeed = 2;
double DogSpeed = 5;
double friend = 2;
double distance = 10000;
double count = 0;
double time = 0;


while (distance > 10)
{
if (friend == 1)
{
time = distance / (FirstFriendSpeed + DogSpeed);
friend = 2;
}
else
{
 time = distance / (SecondFriendSpeed + DogSpeed);
 friend = 1;
}

distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;

count++;

};
Console.Write("Dog Ran ");
Console.WriteLine(count);