// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ShiftChanges_Environment
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
  public class ShiftChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ShiftChanges_Environment_ObjectToChange")]
    [Metadata("Typically applies to manufacturing companies that have areas staffed for a long enough during a day that workers do not all start and end their day at the same time.  Shift is a mechanism for grouping production information based on management responsibilities for workers that start and leave at a particular time.  For example, the \"Day\" shift might work from 6am to 6pm, and the \"Night\" shift would work from 6pm to 6am. ", "Shift", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ShiftChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1049947, false, false, false, null)]
    protected new Environment _Name;

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
