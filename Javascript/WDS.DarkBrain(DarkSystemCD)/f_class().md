### f_class();

WDS.DarkBrain(DarkSystemCD)[logic production engine]<br>
f_class is a multi-purpose javascript function to handle and check element class databases;<hr>

* the ***FunctionLog*** is available for reference to the f_class usability;
* the **ClassUpdate** is available for management of the element class;
* the **ClassDatabase** is available for hosting the document classes;<br>
being a database, consistency for indexes must remain once archived;

```javascript
//[:] CLASSES    [database,index\'class'],element    ;
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
     ,"[E] f_class() element class issue;"
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
    for(let v10=0; v10<VV0.length; v10++){
      if(v90.classList.contains(VV0[v10]) &&
         VV0[v10] != VV0[V0[1]]){
        return v90.setAttribute("class", v90.classList.toString().
                                        replace(VV0[v10],VV0[V0[1]]));
      }else{
        if(v90.classList.contains(VV0[v10])){
          return L(6,"\n\[ ] "+VV0[V0[1]]),null;
        }
        return L(5,"\n\[?] the element class does not contain:: "+VV0[v10]+
                   "\n\--> the element.classList is\n\    ("+v90.classList+")"),
               null;
      }
    }
  }
if(V0 && Array.isArray(V0) && V0.length>=2){
var v10 = null;
  if(typeof V0[1] === 'string'){v10 = true;}
//[?]ClassDatabase;
switch(V0[0]){
case 1:
    let v30=["theme-default","theme-test"];
    //[?]CheckOnly;
    if(v10){
      if(v30.indexOf(V0[1])>=0){
        return L(2),true;
      }else{return L(3),null;}
    }
    return f_class_update(v30);
case 2:
default: return L(1),null;
}
}else{return L(0),null;}
}
```
