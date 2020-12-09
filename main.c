#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Hello world!\n");

    int sayi;
    int sayi2;
    printf("lutfen 1 ile 10 arasinda bir sayi giriniz : \n");
    scanf("%d",&sayi);

    if (sayi >= 1 && sayi <= 10)
    {
      switch (sayi)
      {
          case 2:
          case 3:
          case 5:
          case 7:printf("asal sayi girdiniz : \n");
          break;
          default:printf("girdiginiz sayi asal degildir : \n");
      }
    }
    else printf("aralik disi bir deger girdiniz : \n");

    return 0;
}
