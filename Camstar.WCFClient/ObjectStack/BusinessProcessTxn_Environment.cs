// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessProcessTxn_Environment
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
  public class BusinessProcessTxn_Environment : GenericTxn_Environment
  {
    [Metadata("Comments", "", false, false, false, "String", 16777408, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessTxn_Environment_Comments")]
    protected new Environment _Comments;
    [Metadata("A CDO with the intention of being subclassed for usage in a business process which includes possibly a workflow.", "TrackableObject", false, true, false, "BaseObjectRef", 1051446, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessProcessTxn_Environment_TrackableObject")]
    protected new Environment _TrackableObject;

    public new Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public new Environment TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObject));
      }
    }
  }
}
