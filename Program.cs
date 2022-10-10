
  double salario = 0.00; 
    double reajuste = 0.00; 
    double novoSalario = 0.00; 
    double percentual = 0.00; 


  Console.WriteLine("Digite o salário:");
  salario = Convert.ToDouble(Console.ReadLine()); 

//TODO: Complete os espaços em branco com uma possível solução para o problema:
   
    if(salario <= 400.00 && salario > 0.00) { 
     
      percentual = 15/100;
      reajuste = salario * 15/100;
      novoSalario = salario + reajuste;
      return; 

    } else if (salario <= 800.00 && salario > 400.00) { 
      percentual = 12%; 
      reajuste = salario * 12/100; 
      novoSalario = salario + reajuste; 


    } else if (salario <= 1200.00 && salario > 800.00) { 
      percentual = 10%; 
      reajuste = salario * 10/100;         
      novoSalario = salario + reajuste; 

    } else if (salario <= 2000.00 && salario > 1200.00) { 
      percentual = 7%; 
      reajuste =  salario * 7/100; 
      novoSalario = salario + reajuste; 

    } else if (salario > 2000.00) { 
      percentual =  4%; 
      reajuste =  salario * 4/100; 
      novoSalario =  reajuste + salario; 

    } 

    Console.WriteLine("Novo salario: {0:0.00}", novoSalario); 
    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste); 
    Console.WriteLine("Em percentual: {0} %", percentual ); 

   