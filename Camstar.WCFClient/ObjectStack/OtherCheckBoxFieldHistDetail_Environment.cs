// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OtherCheckBoxFieldHistDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (EventTypeHistoryDetail_Environment))]
  [KnownType(typeof (ReportSourceHistoryDetail_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (DeviceOperatorHistoryDetail_Environment))]
  [Serializable]
  public class OtherCheckBoxFieldHistDetail_Environment : EventCheckBoxFieldHistDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "OtherCheckBoxFieldHistDetail_Environment_OtherText")]
    [Metadata("Generic String", "", false, false, true, "String", 1051302, false, false, false, null)]
    protected Environment _OtherText;
    [DataMember(EmitDefaultValue = false, Name = "OtherCheckBoxFieldHistDetail_Environment_Other")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051301, false, false, false, "0")]
    protected Environment _Other;

    public Environment OtherText
    {
      [param: In] set
      {
        this.PropertySet(nameof (OtherText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OtherText));
      }
    }

    public Environment Other
    {
      [param: In] set
      {
        this.PropertySet(nameof (Other), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Other));
      }
    }
  }
}
