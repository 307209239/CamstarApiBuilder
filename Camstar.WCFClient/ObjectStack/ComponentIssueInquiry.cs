// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentIssueInquiry
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
  public class ComponentIssueInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueInquiry_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueInquiry_IssueDetails")]
    protected IssueDetails _IssueDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueInquiry_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueInquiry_BOMLineItem")]
    protected NamedSubentityRef _BOMLineItem;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueInquiry_UOM2")]
    protected NamedObjectRef _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueInquiry_ParentContainer")]
    protected ContainerRef _ParentContainer;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueInquiry_ObjectName")]
    protected Primitive<string> _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueInquiry_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueInquiry_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueInquiry_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is ComponentIssueInquiry && object.Equals((object) this._Qty2, (object) ((ComponentIssueInquiry) obj)._Qty2) && (object.Equals((object) this._IssueDetails, (object) ((ComponentIssueInquiry) obj)._IssueDetails) && object.Equals((object) this._UOM, (object) ((ComponentIssueInquiry) obj)._UOM)) && (object.Equals((object) this._BOMLineItem, (object) ((ComponentIssueInquiry) obj)._BOMLineItem) && object.Equals((object) this._UOM2, (object) ((ComponentIssueInquiry) obj)._UOM2) && (object.Equals((object) this._ParentContainer, (object) ((ComponentIssueInquiry) obj)._ParentContainer) && object.Equals((object) this._ObjectName, (object) ((ComponentIssueInquiry) obj)._ObjectName))) && (object.Equals((object) this._Container, (object) ((ComponentIssueInquiry) obj)._Container) && object.Equals((object) this._Qty, (object) ((ComponentIssueInquiry) obj)._Qty) && object.Equals((object) this._Product, (object) ((ComponentIssueInquiry) obj)._Product)) && base.Equals(obj);
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
