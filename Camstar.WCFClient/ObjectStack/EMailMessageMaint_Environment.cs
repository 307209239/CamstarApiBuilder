// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EMailMessageMaint_Environment
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
  public class EMailMessageMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageMaint_Environment_ObjectListInquiry")]
    [Metadata("EMail with details to be used in sending email.", "EMailMessage", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("EMail with details to be used in sending email.", "EMailMessageChanges", false, false, false, "EMailMessageChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageMaint_Environment_ObjectChanges")]
    protected EMailMessageChanges_Environment _ObjectChanges;
    [Metadata("EMail with details to be used in sending email.", "EMailMessage", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

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

    public EMailMessageChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (EMailMessageChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
