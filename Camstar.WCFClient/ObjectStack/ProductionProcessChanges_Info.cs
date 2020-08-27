// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductionProcessChanges_Info
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
  public class ProductionProcessChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Info_ExecutionMode")]
    protected Info _ExecutionMode;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Info_DisplayMode")]
    protected Info _DisplayMode;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Info_EProcedureDetails")]
    protected ProductionProcessDetailChanges_Info _EProcedureDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Info_IsRevOfRcd")]
    protected new Info _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessChanges_Info_Name")]
    protected new Info _Name;

    public Info ExecutionMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecutionMode));
      }
    }

    public Info DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayMode));
      }
    }

    public ProductionProcessDetailChanges_Info EProcedureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EProcedureDetails), (object) value);
      }
      get
      {
        return (ProductionProcessDetailChanges_Info) this.PropertyGet(nameof (EProcedureDetails));
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
  }
}
