// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResponseSetChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ResponseSetChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResponseSetChanges_Environment_Responses")]
    [Metadata("Defines the response entry within Response Set.", "ResponseItemChanges", false, false, false, "ResponseItemChanges", 1052374, false, true, false, null)]
    protected ResponseItemChanges_Environment _Responses;
    [DataMember(EmitDefaultValue = false, Name = "ResponseSetChanges_Environment_ObjectToChange")]
    [Metadata("The Response Set is an object which allows the user to configure various response sets.", "ResponseSet", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052372, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResponseSetChanges_Environment_Name")]
    protected new Environment _Name;

    public ResponseItemChanges_Environment Responses
    {
      [param: In] set
      {
        this.PropertySet(nameof (Responses), (object) value);
      }
      get
      {
        return (ResponseItemChanges_Environment) this.PropertyGet(nameof (Responses));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
