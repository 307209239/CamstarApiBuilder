// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OtherCheckBoxField_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (DeviceOperatorField_Environment))]
  [KnownType(typeof (EventTypeField_Environment))]
  [KnownType(typeof (ReportSourceField_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class OtherCheckBoxField_Environment : EventCheckBoxField_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "OtherCheckBoxField_Environment_Other")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051301, false, false, false, "0")]
    protected Environment _Other;
    [DataMember(EmitDefaultValue = false, Name = "OtherCheckBoxField_Environment_OtherText")]
    [Metadata("Generic String", "", false, false, false, "String", 1051302, false, false, false, null)]
    protected Environment _OtherText;

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
  }
}
