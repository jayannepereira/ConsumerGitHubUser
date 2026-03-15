import java.util.Scanner;

public class MyClass {
  public static void main(String args[]) {
     Scanner scanner = new Scanner(System.in);
      
     System.out.println("Escreva o valor total da compra: ");
     int valor1 = scanner.nextInt();
     
     System.out.println("Escreva o valor total pago: ");
     int valor2 = scanner.nextInt();
     
     if(valor2 < valor1){
        int falta = valor1 - valor2;
        System.out.println("A quantia paga é insuficiente para realizar a compra!");
        System.out.println("Falta R$" + falta + ",00.");
     }else{
        int troco = valor2 - valor1;
        System.out.println("Valor da compra: R$" + valor1 + ",00");
        System.out.println("Valor pago: R$" + valor2 + ",00");
        System.out.println("Troco: R$" + troco + ",00");
        
        int[] notas = {50, 20, 10, 5, 2, 1};
        
         for (int nota : notas) {
            int quantidadeNotas = troco / nota; 
            if (quantidadeNotas > 0) {  
                System.out.println("Nota(s) de R$" + nota + ",00: " + quantidadeNotas);
                troco = troco % nota;
         }
    }
    }
}
}