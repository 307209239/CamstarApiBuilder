// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentReplaceInquiry
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
  public class ComponentReplaceInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_IssueDetails")]
    protected IssueDetails _IssueDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_BOMLineItem")]
    protected NamedSubentityRef _BOMLineItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_ShowAsBuilt")]
    protected Primitive<bool> _ShowAsBuilt;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_ObjectName")]
    protected Primitive<string> _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_ParentContainer")]
    protected ContainerRef _ParentContainer;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ComponentReplaceInquiry_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is ComponentReplaceInquiry && object.Equals((object) this._IssueDetails, (object) ((ComponentReplaceInquiry) obj)._IssueDetails) && (object.Equals((object) this._BOMLineItem, (object) ((ComponentReplaceInquiry) obj)._BOMLineItem) && object.Equals((object) this._Qty2, (object) ((ComponentReplaceInquiry) obj)._Qty2)) && (object.Equals((object) this._UOM, (object) ((ComponentReplaceInquiry) obj)._UOM) && object.Equals((object) this._UOM2, (object) ((ComponentReplaceInquiry) obj)._UOM2) && (object.Equals((object) this._ShowAsBuilt, (object) ((ComponentReplaceInquiry) obj)._ShowAsBuilt) && object.Equals((object) this._ObjectName, (object) ((ComponentReplaceInquiry) obj)._ObjectName))) && (object.Equals((object) this._ParentContainer, (object) ((ComponentReplaceInquiry) obj)._ParentContainer) && object.Equals((object) this._Container, (object) ((ComponentReplaceInquiry) obj)._Container) && (object.Equals((object) this._Qty, (object) ((ComponentReplaceInquiry) obj)._Qty) && object.Equals((object) this._Product, (object) ((ComponentReplaceInquiry) obj)._Product))) && base.Equals(obj);
    }

    public IssueDetails IssueDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDetails), (object) value);
      }
      get
      {
        return (IssueDetails) this.PropertyGet(nameof (IssueDetails));
      }
    }

    public NamedSubentityRef BOMLineItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (BOMLineItem), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (BOMLineItem));
      }
    }

    public Primitive<double> Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2));
      }
    }

    public NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
      }
    }

    public NamedObjectRef UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM2));
      }
    }

    public Primitive<bool> ShowAsBuilt
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAsBuilt), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowAsBuilt));
      }
    }

    public Primitive<string> ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectName));
      }
    }

    public ContainerRef ParentContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (ParentContainer));
      }
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }

    public RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }
  }
}
