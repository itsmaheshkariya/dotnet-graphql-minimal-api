dotnet add package Microsoft.EntityFrameworkCore --version 6.0.1
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.1
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.1
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.1
dotnet add package HotChocolate.AspNetCore --version 12.6.0

dotnet tool install --global dotnet-ef 
dotnet ef migrations add InitialCreate 


dotnet ef migrations add InitialCreate
dotnet database update 

 
query{
   allUsers{
     id
     name
     email
     password
   }
}



mutation($newUser:UserInput!) {
   createUser(user:$newUser) {
     id
   }
}



mutation($updateUser:UserInput!) {
  updateUser(updateUser: $updateUser) {
    id
  } 
}

mutation($id:Int!){
  deleteUser(id:$id)
}
{
  "id": 1
}

{
  "newUser":{
    "id": 0,
    "name": "mahesh",
    "email": "mahesh@gmail.com",
    "password": "mahesh@123"
  }
}