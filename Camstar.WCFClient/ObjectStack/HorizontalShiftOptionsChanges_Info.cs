// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HorizontalShiftOptionsChanges_Info
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
  public class HorizontalShiftOptionsChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptionsChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptionsChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptionsChanges_Info_HorizontalShiftDirection")]
    protected Info _HorizontalShiftDirection;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptionsChanges_Info_HorizontalShiftValue")]
    protected Info _HorizontalShiftValue;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptionsChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
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
