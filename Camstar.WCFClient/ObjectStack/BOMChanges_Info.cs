// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BOMChanges_Info
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
  public class BOMChanges_Info : BillChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_Info_MaterialList")]
    protected ProductMaterialListItemChanges_Info _MaterialList;
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_Info_MaterialListItem")]
    protected ProductMaterialListItemChanges_Info _MaterialListItem;
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_Info_IsRevOfRcd")]
    protected new Info _IsRevOfRcd;

    public ProductMaterialListItemChanges_Info MaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialList), (object) value);
      }
      get
      {
        return (ProductMaterialListItemChanges_Info) this.PropertyGet(nameof (MaterialList));
      }
    }

    public ProductMaterialListItemChanges_Info MaterialListItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialListItem), (object) value);
      }
      get
      {
        return (ProductMaterialListItemChanges_Info) this.PropertyGet(nameof (MaterialListItem));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

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

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public new Info IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }
  }
}
