// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ERPBOMChanges_Info
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
  public class ERPBOMChanges_Info : BillChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Info_ERPRoute")]
    protected Info _ERPRoute;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Info_MaterialListItem")]
    protected BOMMaterialListItemChanges_Info _MaterialListItem;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Info_MaterialList")]
    protected BOMMaterialListItemChanges_Info _MaterialList;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Info_ExternallyControlled")]
    protected Info _ExternallyControlled;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Info_IsRevOfRcd")]
    protected new Info _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ERPBOMChanges_Info_Status")]
    protected new Info _Status;

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

    public Info ERPRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (ERPRoute), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ERPRoute));
      }
    }

    public BOMMaterialListItemChanges_Info MaterialListItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialListItem), (object) value);
      }
      get
      {
        return (BOMMaterialListItemChanges_Info) this.PropertyGet(nameof (MaterialListItem));
      }
    }

    public BOMMaterialListItemChanges_Info MaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialList), (object) value);
      }
      get
      {
        return (BOMMaterialListItemChanges_Info) this.PropertyGet(nameof (MaterialList));
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

    public Info ExternallyControlled
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExternallyControlled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExternallyControlled));
      }
    }

    public new Info IsFrozen
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

    public new Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
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

    public new Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }
  }
}
