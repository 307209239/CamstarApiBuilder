// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReorderProcessObject_Environment
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
  public class ReorderProcessObject_Environment : ProcessObjectTxn_Environment
  {
    [Metadata("Used to sort details in a process object", "ReorderProcessObjectDetail", false, false, false, "ReorderProcessObjectDetail", 1049843, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObject_Environment_ServiceDetails")]
    protected ReorderProcessObjectDetail_Environment _ServiceDetails;
    [Metadata("An abstract class to hold the common attributes of the Process objects.", "ProcessObject", false, true, false, "NamedSubentityRef", 1051396, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObject_Environment_ProcessObject")]
    protected new Environment _ProcessObject;

    public ReorderProcessObjectDetail_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ReorderProcessObjectDetail_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public new Environment ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessObject));
      }
    }
  }
}
