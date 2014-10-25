using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagineCup.Quantum
{
    public static class SpaceMath
    {
        public static void madeTransform(GameObject f, GameObject s)
        {
            // TODO написать преобразование объектов.

            // скорость  = sqrt(M*G/R)
        }

//        public static void voidTest()
//        {
//            //void CPlanetSystem::Move(float time) 
//            XYZ vectors[MAX_PLANETS_IN_SYSTEM+1]; 
//            XYZ positions[MAX_PLANETS_IN_SYSTEM+1]; 
//            float masses[MAX_PLANETS_IN_SYSTEM+1];

//          int i,j; 
//          for(i=0;i<MAX_PLANETS_IN_SYSTEM;i++)
//              vectors = planets.velocity; 
//           vectors[MAX_PLANETS_IN_SYSTEM]  =sun.velocity; 
//          for(i=0;i<MAX_PLANETS_IN_SYSTEM;i++)
//              positions=planets.position; 
//              positions[MAX_PLANETS_IN_SYSTEM]=sun.position; 
//          for(i=0;i<MAX_PLANETS_IN_SYSTEM;i++)
//              masses  = planets.mass;
//          masses[MAX_PLANETS_IN_SYSTEM]  =sun.mass;

//            for(i=numofplanets;i<MAX_PLANETS_IN_SYSTEM;i++)masses=0.0f; 
  
//  for(i=0;i<MAX_PLANETS_IN_SYSTEM+1;i++) 
//  for(j=0;j<MAX_PLANETS_IN_SYSTEM+1;j++) 
//  {  
//    float F; 
//    float sqln=sqrlen(positions,positions[j]); 
//    if(sqln>EPS)F=Gconst*masses*masses[j]/sqln;else F=0;

    
//    float a1;if(masses>EPS)a1=F/masses;else a1=0; 
//    float a2;if(masses[j]>EPS)a2=F/masses[j];else a2=0; 
    
//    XYZ a11=trnMinusVec(positions[j],positions); 
//    XYZ a22=trnMinusVec(positions,positions[j]);

//    float o1=(sqrt(SQR(a11.x)+SQR(a11.y)+SQR(a11.z)));if(o1>EPS || o1< -EPS)o1=time/o1;else o1=0; 
//    float o2=(sqrt(SQR(a22.x)+SQR(a22.y)+SQR(a22.z)));if(o2>EPS || o2< -EPS)o2=time/o2;else o2=0;

//    a11=trnMultVec(a11,a1*o1); 
//    a22=trnMultVec(a22,a2*o2); 
   

//    vectors=trnPlusVec(vectors,a11); 
//    vectors[j]=trnPlusVec(vectors[j],a22);

//  }

//  for(i=0;i<MAX_PLANETS_IN_SYSTEM;i++)planets.velocity=vectors; sun.velocity=vectors[MAX_PLANETS_IN_SYSTEM]; 
//  for(i=0;i<MAX_PLANETS_IN_SYSTEM;i++)planets.position=trnPlusVec(planets.position,trnMultVec(vectors,time) ); 
//  sun.position=trnPlusVec(sun.position,trnMultVec(vectors[MAX_PLANETS_IN_SYSTEM],time)); 
//}
    }
}
