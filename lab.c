#include <iostream>
#include <string>

using namespace std;

class Clothing {
   public:
      string Size;  
      string Material;
      string Season;
};

int main() {
   Clothing Cloth1;        
   Clothing Cloth2;
   Clothing Cloth3;
   string output;
 
   Cloth1.Size = "S";
   Cloth1.Material = "Cotton";
   Cloth1.Season = "Summer";
   
   Cloth2.Size = "L";
   Cloth2.Material = "Wool";
   Cloth2.Season = "Winter";
   
   Cloth3.Size = "XL";
   Cloth3.Material = "Leather";
   Cloth3.Season = "Spring";
   
   output = Cloth1.Size + ", " + Cloth1.Material + ", " + Cloth1.Season;
   cout << "Cloth1 parameters : " << output <<endl;

   output = Cloth2.Size + ", " + Cloth2.Material + ", " + Cloth2.Season;
   cout << "Cloth2 parameters : " << output <<endl;
   
   output = Cloth3.Size + ", " + Cloth3.Material + ", " + Cloth3.Season;
   cout << "Cloth3 parameters : " << output <<endl;
   return 0;
}