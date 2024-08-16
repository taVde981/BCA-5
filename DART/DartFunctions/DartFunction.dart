void main(){

display();
print(returnable_display());
String s = "Non-Returnable and Parametrized";
parametrized_display(s);
String a = "Returnable and ", b = "Parametrized";
print(concatination(a, b));
}

void display(){
  print("Non-Returnable and Non-Parametrized Function");
}

String returnable_display(){
String x = "Returnable and Non-Parametrized";
return x;
}

void parametrized_display(String x){
print(x);
}

String concatination(String a, String b){
  return a+b;
}