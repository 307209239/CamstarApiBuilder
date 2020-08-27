// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OtherCheckBoxField_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (DeviceOperatorField_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ReportSourceField_Info))]
  [KnownType(typeof (EventTypeField_Info))]
  [Serializable]
  public class OtherCheckBoxField_Info : EventCheckBoxField_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "OtherCheckBoxField_Info_Other")]
    protected Info _Other;
    [DataMember(EmitDefaultValue = false, Name = "OtherCheckBoxField_Info_OtherText")]
    protected Info _OtherText;

    public Info Other
    {
      [param: In] set
      {
        this.PropertySet(nameof (Other), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Other));
      }
    }

    public Info OtherText
    {
      [param: In] set
      {
        this.PropertySet(nameof (OtherText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OtherText));
      }
    }
  }
}
