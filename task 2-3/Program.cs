using System.Numerics;

int main()
{
   
    int a;
    float b;
    char c;

   
    printf("Int value: %d\n", a);
    printf("Float value: %f\n", b);
    printf("Char value: %c\n", c);

    return 0;
}

using namespace std;

int main()
{
    int a;
    float b;
    char c;

    cout << "Int value: " << a << endl;
    cout << "Float value: " << b << endl;
    cout << "Char value: " << c << endl;

    return 0;
}



struct User
{
    char firstName[50];
    char lastName[50];
    int age;
    int isStudent; 

int main()
{
    int n;
    printf("Enter the number of users: ");
    scanf("%d", &n);

    struct User users[n];

    for (int i = 0; i<n; i++) {
        printf("Enter first name: ");
scanf("%s", users[i].firstName);
printf("Enter last name: ");
scanf("%s", users[i].lastName);
printf("Enter age: ");
scanf("%d", &users[i].age);
printf("Are you a student? (1 for Yes, 0 for No): ");
scanf("%d", &users[i].isStudent);
    }

    printf("\nUser Information:\n");
for (int i = 0; i < n; i++)
{
    printf("Name: %s %s, Age: %d, Student: %s\n",
           users[i].firstName, users[i].lastName, users[i].age,
           users[i].isStudent ? "Yes" : "No");
}

return 0;
}

#include <iostream>
#include <vector>
#include <string>
using namespace std;

struct User
{
    string firstName;
    string lastName;
    int age;
    bool isStudent;
};

int main()
{
    int n;
    cout << "Enter the number of users: ";
    cin >> n;

    vector<User> users(n);

    for (int i = 0; i < n; i++)
    {
        cout << "Enter first name: ";
        cin >> users[i].firstName;
        cout << "Enter last name: ";
        cin >> users[i].lastName;
        cout << "Enter age: ";
        cin >> users[i].age;
        cout << "Are you a student? (1 for Yes, 0 for No): ";
        cin >> users[i].isStudent;
    }

    cout << "\nUser Information:\n";
    for (const auto&user : users) {
        cout << "Name: " << user.firstName << " " << user.lastName
             << ", Age: " << user.age
             << ", Student: " << (user.isStudent ? "Yes" : "No") << endl;
    }

    return 0;
}
