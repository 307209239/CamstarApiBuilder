// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusReasonChanges_Environment
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
  public class ResourceStatusReasonChanges_Environment : UserCodeChanges_Environment
  {
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050113, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusReasonChanges_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusReasonChanges_Environment_ObjectToChange")]
    [Metadata("A Resource Status Reason Code is used to provide an added level of detail describing the reason for the current status of a Resource. For example, the current status may be REPAIR. A Status Reason Code can be used to provide additional details such as the type of repair that is being performed. This detail is included in the transaction history, which makes it available for Analysis Reporting.", "ResourceStatusReason", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;

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
  }
}
