// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UISubmitAction_Environment
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
  public class UISubmitAction_Environment : UIAction_Environment
  {
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052797, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UISubmitAction_Environment_IsReturn")]
    protected Environment _IsReturn;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052798, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UISubmitAction_Environment_ClearValues")]
    protected Environment _ClearValues;
    [DataMember(EmitDefaultValue = false, Name = "UISubmitAction_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052778, false, false, false, null)]
    protected new Environment _Name;

    public Environment IsReturn
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsReturn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsReturn));
      }
    }

    public Environment ClearValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearValues), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ClearValues));
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
