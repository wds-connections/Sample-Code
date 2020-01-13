## ⚙️ f_class();
🚧 version 0.1.0

> WDS.DarkBrain(DarkSystemCD)[logic production engine]

f_class is a multi-purpose javascript function to handle and check element class databases;<hr>

* the ***FunctionLog*** is available for reference to the f_class usability;
* the **ClassUpdate** is available for management of the element class;
* the **ClassDatabase** is available for hosting the document classes;<br>
being a database, consistency for indexes must remain once archived;

```javascript
//[:] CLASSES      [database,index\'class'],element  ;
function f_class(V0,V1){
//WDS.DarkBrain(DarkSystemCD)[logic production engine]
  //[?]FunctionLog;
  function L(VV0,VV1=""){
    var vlog = [
      "[E] f_class() has incorrect parameters; \n\    V0 = "+V0+"\n\[?] V0 must be array with length 2; [X,X]"
     ,"[E] f_class() function database is IndexOutOfRange; \n\    V0[0] = "+V0[0]
     ,"[?] f_class() value where successfully found; \n\    V0[1] = "+V0[1]
     ,"[E] f_class() value where not found in the Class Database;\n\    V0[1] = "+V0[1]
     ,"[E] f_class() element where not found;\n\    V1 = "+V1
     ,"[?] f_class() the element class already contains the value;"
     ,""
        ];
    return console.log(vlog[VV0]+VV1);
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
        if(VV0[v10] == VV0[V0[1]]){
          return L(5,"\n\[v] "+VV0[V0[1]]),null;
        }else{break Loop0;}
      }
    }
    return v90.setAttribute("class", 
               v90.classList.toString().replace(VV0[v10],VV0[V0[1]]));
  }
  //[?]WrongParameters;
  if(!V0 || !Array.isArray(V0) || !V0.length>=2){
    return L(0),undefined;
  }
  //[?]ClassDatabase;
  function f_class_database(VV0,VV1){
    var v10 = null;
    if(typeof V0[1] === 'string'){v10 = true;}
    switch(VV0){
    case 1:
        var v30=["theme-default","theme-test"];
        if(v10){ //[?]CheckOnly;
          if(v30.indexOf(V0[1])>=0){
            return L(2),true;
          }else{return L(3),null;}
        }
        return f_class_update(v30);
    case 2:
    default: return L(1),undefined;
    }
  }
  
  //[?]ValidateValue;UnknownIndex;
  if(V0[0]=="validate"){
    let v10=true,v11=0;
    while(v10){
      v11++;
      if(f_class_database(v11,V0[1])!=undefined){
        v10=false;
        return true;
      }else{return null;}
    }
  }else{
    //[?]Standard:SwitchClass;
    return f_class_database(V0[0]);
  }
}
```
usability are sampled as following ::
```javascript
//Update Element Class Item;
f_class([1,1],this);
f_class([1,'theme-test'],this);
f_class([1,1],'myElementId');
f_class([1,'theme-test'],'myElementId');
//Check for Class Item;
if( f_class([1,'theme-test']) ){}
if( f_class(['validate','theme-test']) ){}
```

thanks for choosing DarkSystemCD.<hr>

[![foo](https://github.githubassets.com/favicon.ico)](https://github.com/DarkSystemCD) [![foo](https://s.imgur.com/images/favicon-32x32.png)](https://imgur.com/user/DarkSystemCD) [![foo](https://a-v2.sndcdn.com/assets/images/sc-icons/favicon-2cadd14bdb.ico)](https://soundcloud.com/darksystemcd)

###### DarkSystemCD® used to identify, meet, work and publish logics and programming design, software, games and music on interfaces and electronic, digital and virtual media.

###### BloodArt.Magazine detailed description available in the projects and productions, developing delivered to collection information in the magazine.
