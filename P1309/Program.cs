int MOD_VALUE = 9901;
int.TryParse(Console.ReadLine(), out var lengthOfCages);
var memo = new int[lengthOfCages, 3];

// 0 : 넣지 않는 경우
// 1 : 왼쪽에 넣는 경우
// 2 : 오른쪽에 넣는 경우

for (var i = 0; i < lengthOfCages; i++)
{
    memo[i, 0] = 1;
    memo[i, 1] = 1;
    memo[i, 2] = 1;
}

for (var i = 1; i < lengthOfCages; i++)
{
    memo[i, 0] = (memo[i - 1, 0] + memo[i - 1, 1] + memo[i - 1, 2]) % MOD_VALUE;
    memo[i, 1] = (memo[i - 1, 0] + memo[i - 1, 2]) % MOD_VALUE;
    memo[i, 2] = (memo[i - 1, 0] + memo[i - 1, 1]) % MOD_VALUE;
}

var answer = (memo[lengthOfCages - 1, 0] + memo[lengthOfCages - 1, 1] + memo[lengthOfCages - 1, 2]) % MOD_VALUE;

Console.WriteLine(answer);