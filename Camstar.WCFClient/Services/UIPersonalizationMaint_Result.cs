// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UIPersonalizationMaint_Result
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class UIPersonalizationMaint_Result : Result
  {
    [DataMember(EmitDefaultValue = false, Name = "Value")]
    protected UIPersonalizationMaint _Value;
    [DataMember(EmitDefaultValue = false, Name = "Environment")]
    protected UIPersonalizationMaint_Environment _Environment;

    public UIPersonalizationMaint Value
    {
      [param: In] set
      {
        this.PropertySet(nameof (Value), (object) value);
      }
      get
      {
        return (UIPersonalizationMaint) this.PropertyGet(nameof (Value));
      }
    }

    public UIPersonalizationMaint_Environment Environment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Environment), (object) value);
      }
      get
      {
        return (UIPersonalizationMaint_Environment) this.PropertyGet(nameof (Environment));
      }
    }
  }
}
