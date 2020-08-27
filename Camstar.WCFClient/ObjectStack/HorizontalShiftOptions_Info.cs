// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HorizontalShiftOptions_Info
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
  public class HorizontalShiftOptions_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptions_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptions_Info_HorizontalShiftDirection")]
    protected Info _HorizontalShiftDirection;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptions_Info_HorizontalShiftValue")]
    protected Info _HorizontalShiftValue;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptions_Info_IsFrozen")]
    protected Info _IsFrozen;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info HorizontalShiftDirection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HorizontalShiftDirection), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HorizontalShiftDirection));
      }
    }

    public Info HorizontalShiftValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (HorizontalShiftValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HorizontalShiftValue));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
