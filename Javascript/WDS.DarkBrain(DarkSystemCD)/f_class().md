## ⚙️ f_class();
🚧 version 0.1

> WDS.DarkBrain(DarkSystemCD)[logic production engine]

f_class is a multi-purpose javascript function to handle and check element class databases;<hr>

* the ***FunctionLog*** is available for reference to the f_class usability;
* the **ClassUpdate** is available for management of the element class;
* the **ClassDatabase** is available for hosting the document classes;<br>
being a database, consistency for indexes must remain once archived;<br>
even so the automatic ability to handle items remains to manually overcheck the indexed database;

```javascript
//[:] CLASSES      [database,index\'class'],element  ;
function f_class(V0,V1){
//WDS.DarkBrain(DarkSystemCD)[logic production engine]
  var v20 = null;
  //[?]FunctionLog;
  function L(VV0,VV1=""){
    var vlog = [
      "[E] f_class() has incorrect parameters; \n\    V0 = "+V0+
      "\n\    V1 = "+V1+"\n\ to apply class update V1 is required;"
     ,"[E] f_class() function database is IndexOutOfRange; \n\    V0[0] = "+V0[0]
     ,"[?] f_class() value where successfully found;"
     ,"[E] f_class() value where not found in the Class Database;\n\    V0[1] = "+V0[1]
     ,"[E] f_class() element where not found;\n\    V1 = "+V1
     ,"[?] f_class() the element class already contains the value;"
     ,""
        ];
    return console.log("\n\ "+vlog[VV0]+VV1+"\n\ ");
  }
  //[?]ClassUpdate:SafeChecks;
  function f_class_update(VV0){
    let v90 = V1;
    if(v90){
      if(v90.nodeType !== Node.ELEMENT_NODE){
        if(v90 != document.getElementById(v90)){
          return L(4,"\n\[?] the element is not a node;"+
                     "\n\[?] element ID is incorrect;"),null;
        }
      }
    }else{return L(4),null;}
    let v10;
    Loop0:
    for(v10=0; v10<VV0.length; v10++){
      if(v90.classList.contains(VV0[v10])){
        if(VV0[v10] == v20){
          return L(5,"\n\ [v] "+v20),null;
        }else{break Loop0;}
      }
    }
    return v90.setAttribute("class", 
               v90.classList.toString().replace(VV0[v10],v20));
  }
  //[?]WrongParameters;
  if(!V0 || !Array.isArray(V0)){return L(0),undefined;}
  if(typeof V0[0]==='string' &&
     typeof V0[1]==='string' && !V1){}else{
  if(!typeof V0[0]==='string' && V1 || 
      typeof V0[0]==='string' && !V1){return L(0),undefined;}}
  if(V0.length<2){v20=V0[0];}
  else{if(typeof V0[1]==='string'){v20=V0[1];}}
  //[?]ClassDatabase;
  function f_class_database(VV0,VV1){
    var v10 = null;
    if(typeof V0[1] === 'string'){v10 = true;}
    switch(VV0){
    case 1:
        var v30=["theme-default","theme-test"];
        if(v10){
          if(v30.indexOf(v20)>=0){
            if(!v20 || !V1){return L(2),true;}
          }else{return L(3),null;}
        }
        if(!v20){v20=v30[V0[1]]}
        return f_class_update(v30);
    case 2:
    default: return L(1,v20),undefined;
    }
  }
  
  //[?]ValidateValue;UnknownIndex;
  if(V0[0]=="validate"||v20){
    let v10=true,v11=0;
    while(v10){
      v11++;
      if(f_class_database(v11,v20)!=undefined){
        v10=false;
        return true;
      }else{return null;}
    }
  }else{
    //[?]Standard:SwitchClass;
    return f_class_database(V0[0],V0[1]);
  }
}
```
usability are sampled as following ::
```javascript
//Update Element Class Item;
f_class(['theme-test'],this);                //Automatic              Current Element;
f_class([1,1],this);                         //Indexed                Current Element;
f_class([1,'theme-test'],this);              //Indexed Specification  Current Element;
f_class(['theme-test'],'myElementId');       //Automatic              Search Element;
f_class([1,1],'myElementId');                //Indexed                Search Element;
f_class([1,'theme-test'],'myElementId');     //Idexed Specification   Search Element;
//Check for Class Item;
if( f_class([1,'theme-test']) ){}            //Indexed                No Element CheckOnly;
if( f_class(['validate','theme-test']) ){}   //UnknownIndex           No Element CheckOnly;
```

thanks for choosing DarkSystemCD.<hr>

<!--
the path of humanity had interrupted the development of computer games,
resulting the availability of this document a self-incriminatory value of productivity
in which said choices to promote societies where manipulated at open source concepts;
the meaning of these situations is the privacy of permanence on the planet
on that the productivity would be used by more socially capable individuals to perpetuate its acts
where the DarkSystemCD® personal projects are illusions of being consumed as the values of other individuals;
this is a intellectual property created for my creations;
the creation process at the virtual reality is a customization process of the available logics,
like dictionary and words that makes books so then lost in social endeavors;
-->

[![foo](https://github.githubassets.com/favicon.ico "DarkSystemCD®")](https://github.com/DarkSystemCD) [![foo](https://a-v2.sndcdn.com/assets/images/sc-icons/favicon-2cadd14bdb.ico "DarkSystemCD®")](https://soundcloud.com/darksystemcd)

###### DarkSystemCD® used to identify, meet, work and publish logics and programming design, software, games and music on interfaces and electronic, digital and virtual media.

###### BloodArt.Magazine detailed description available in the projects and productions, developing delivered to collection information in the magazine.

###### WDHellS a virtual personal person trademark and nickname, created for display my creations enabling it’s available world wide.
