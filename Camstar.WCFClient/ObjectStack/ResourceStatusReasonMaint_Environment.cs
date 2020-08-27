// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusReasonMaint_Environment
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
  public class ResourceStatusReasonMaint_Environment : UserCodeMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusReasonMaint_Environment_ObjectChanges")]
    [Metadata("Changes CDO for ResourceStatusReason.", "ResourceStatusReasonChanges", false, false, false, "ResourceStatusReasonChanges", 1048873, true, false, false, null)]
    protected ResourceStatusReasonChanges_Environment _ObjectChanges;
    [Metadata("A Resource Status Reason Code is used to provide an added level of detail describing the reason for the current status of a Resource. For example, the current status may be REPAIR. A Status Reason Code can be used to provide additional details such as the type of repair that is being performed. This detail is included in the transaction history, which makes it available for Analysis Reporting.", "ResourceStatusReason", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusReasonMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusReasonMaint_Environment_ObjectToChange")]
    [Metadata("A Resource Status Reason Code is used to provide an added level of detail describing the reason for the current status of a Resource. For example, the current status may be REPAIR. A Status Reason Code can be used to provide additional details such as the type of repair that is being performed. This detail is included in the transaction history, which makes it available for Analysis Reporting.", "ResourceStatusReason", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;

    public ResourceStatusReasonChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ResourceStatusReasonChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
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
