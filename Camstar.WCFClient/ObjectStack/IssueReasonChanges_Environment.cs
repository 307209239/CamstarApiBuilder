// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueReasonChanges_Environment
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
  public class IssueReasonChanges_Environment : UserCodeChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueReasonChanges_Environment_ObjectToChange")]
    [Metadata("A list of reason codes that describe the purpose of a component issue.", "IssueReason", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "IssueReasonChanges_Environment_ApplyToReq")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049512, false, false, false, "1")]
    protected Environment _ApplyToReq;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050106, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueReasonChanges_Environment_Name")]
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

    public Environment ApplyToReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplyToReq), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApplyToReq));
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
