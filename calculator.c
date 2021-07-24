#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n1, n2;
    char op;
    int result;
    char re;

    restart:
    printf("첫번째 숫자를 입력하세요 : ");
    scanf("%d", &n1);
    rewind(stdin);

    err:
    printf("부호를 입력하세요 (+, -, *, /) : ");
    scanf("%c", &op);
    rewind(stdin);

    if(op == '+' || op == '-' || op == '*' || op == '/')
    {
        goto pass;
    }
    else
    {
        printf("부호를 확인해 주세요\n");
        goto err;
    }
    pass:
    printf("두번째 숫자를 입력하세요 : ");
    scanf("%d", &n2);
    rewind(stdin);

    result = (op == '+') ? (n1 + n2) : (op == '-') ? (n1 - n2) : (op == '*') ? (n1 * n2) : (n1 / n2);
    printf("계산 결과 : %d\n", result);
    check:
    printf("다시 하시려면 Y 를 종료하시려면 N 을 입력하세요 : ");
    scanf("%c", &re);
    rewind(stdin);

    if (re == 'y' || re == 'Y')
    {
        system("cls");
        goto restart;
    }
    else if (re == 'n' || re == 'N')
    {
        exit(0);
    }
    else
    {
        printf("y, n 중에서 입력해 주세요\n");
        goto check;
    }

    return 0;
}