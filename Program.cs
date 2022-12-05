using System;
using System.Collections.Generic;
namespace XO{
    class Program{
        static int Main(){
            char[,] board = new char[3, 3]{{'_','_','_'},{'_','_','_'},{'_','_','_'}};
            Drawboard(board);
            var Isx =true;
            int choices =9;
            int x=0;
            int y=0;
            //bool won =false;
            while(choices>0){
                
               Console.WriteLine("enter the position you want");
               string input=Console.ReadLine();
               string[] position=input.Split(' ');
               x=int.Parse(position[0]);
               y=int.Parse(position[1]);
              

               while(board[x,y]!='_'){
                    Console.WriteLine("the position you want is occupied enter new position you want");
                    input=Console.ReadLine();
                    position=input.Split(' ');
                    x=int.Parse(position[0]);
                    y=int.Parse(position[1]);
                   

                }
                if(Isx){
                    board[x,y]='X';
                    

                }else{board[x,y]='O';}
                Isx=!Isx;
              char whowin= CheckWinner(board);
              
               if(whowin=='X'){
                    Console.WriteLine("X is won! ");
                    Drawboard(board);
                    return -1;
               }else if(whowin =='O'){
                    Console.WriteLine("O is won! ");
                    Drawboard(board);
                    return -1;

               }
              

                Drawboard(board);
             choices--;
            }
            Console.WriteLine("Game Over! ");
            return 0;

            

        
        }
    
    static void Drawboard(char[,] Board){
        int width=13;
        int height=4;

        for(int i=0;i<height;i++){
            int x = i-1;
            int y =-1;
            for(int j=0; j<width; j++){
                if(i==0){
                    Console.Write("_");
                }else{
                    if(j%4==0){
                        Console.Write("|");
                        y++;
                    }else
                        if(j%2==0 && Board[x,y]!='_' ) {
                        
                                Console.Write($"{Board[x,y]}");
                        }else{
                             Console.Write("_");
                        }
                    }
                      
                }
                
                Console.WriteLine();

            }
        }
        static char CheckWinner(char[,] board){
            for(int i=0;i<3; i++){
                if(board[i,0]!='_'&&board[i,0]==board[i,1]&&board[i,1]==board[i,2]){
                   return board[i,0];
                }
            
            }
            for(int i=0;i<3; i++){
                if(board[0,i]!='_'&&board[0,i]==board[1,i]&&board[1,i]==board[2,i]){
                    return board[0,i];
                }
            
            }
            if(board[0,0]!='_'&&board[0,0]==board[1,1]&&board[1,1]==board[2,2]){
                  return board[0,0];
            }
            if(board[2,0]!='_'&&board[2,0]==board[1,1]&&board[1,1]==board[0,2]){
                 return board[2,0];
            }
            return '_';
        }


    }
}
