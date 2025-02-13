services.AddAuthentication("Project2Scheme")
    .AddCookie("Project2Scheme", options => {
        options.Cookie.Name = "Project2.Cookie"; // Уникальное имя куки
    });



Домашнее задание. TypeScript


Given an array, transform it into an object type and the key/value must be in the provided array.
Example


const tuple = ['tesla', 'model 3', 'model X', 'model Y'] as const

type result = TupleToObject<typeof tuple> // expected { 'tesla': 'tesla', 'model 3': 'model 3', 'model X': 'model X', 'model Y': 'model Y'}


Implement a type that adds a new field to the interface. The type takes the three arguments. The output should be an object with the new field.

type Test = { id: '1' }

type Result = AppendToObject<Test, 'value', 4> // expected to be { id: '1', value: 4 }
