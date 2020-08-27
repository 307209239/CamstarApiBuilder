// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HorizontalShiftOptions_Environment
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
  public class HorizontalShiftOptions_Environment : Subentity_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptions_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptions_Environment_HorizontalShiftDirection")]
    [Metadata("Horizontal Shift Type\r\n1- Left\r\n2 - Right\r\n3- None", "UIHorizontalShiftTypeEnum", false, false, true, "Integer", 1052826, false, false, true, null)]
    protected Environment _HorizontalShiftDirection;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptions_Environment_HorizontalShiftValue")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052822, false, false, false, null)]
    protected Environment _HorizontalShiftValue;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptions_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment HorizontalShiftDirection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HorizontalShiftDirection), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HorizontalShiftDirection));
      }
    }

    public Environment HorizontalShiftValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (HorizontalShiftValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HorizontalShiftValue));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
