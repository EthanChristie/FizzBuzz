# FizzBuzz
You know the drill!  
  
But in case you don't:  
Outputs numbers starting from 1 and incrementing, but:  
If the number is divisible by 3, prints `Fizz` instead.  
If the number is divisible by 5, prints `Buzz` instead.  
If the number is divisible by both 3 *and* 5, prints `FizzBuzz` instead.  

## Prerequisites
.NET Core 3.0 runtime

## Usage
```
dotnet run [numberToSolveFor]
```

`numberToSolveFor` defaults to 100 if not supplied


## Examples

### Default
```
dotnet run
```

Will display

```
1
2
Fizz
4
Buzz
Fizz
...
<snip>
...
97
98
Fizz
Buzz
```

in the console

### Number supplied

```
dotnet run 5
```

Will display

```
1
2
Fizz
4
Buzz
```

in the console
