// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LotSizeDetailsChanges_Environment
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
  public class LotSizeDetailsChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "LotSizeDetailsChanges_Environment_ListItemToChange")]
    [Metadata("A list of min./max. ranges used to define sample sizes.", "LotSizeDetailsChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "LotSizeDetailsChanges_Environment_ObjectToChange")]
    [Metadata("A list of min./max. ranges used to define sample sizes.", "LotSizeDetails", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1053165, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LotSizeDetailsChanges_Environment_MaxLotQty")]
    protected Environment _MaxLotQty;
    [DataMember(EmitDefaultValue = false, Name = "LotSizeDetailsChanges_Environment_MinLotQty")]
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1053166, false, false, false, null)]
    protected Environment _MinLotQty;
    [DataMember(EmitDefaultValue = false, Name = "LotSizeDetailsChanges_Environment_SampleSizeCode")]
    [Metadata("Generic String", "", false, true, false, "String", 1053167, false, false, false, null)]
    protected Environment _SampleSizeCode;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 0, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "LotSizeDetailsChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment MaxLotQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxLotQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxLotQty));
      }
    }

    public Environment MinLotQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinLotQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinLotQty));
      }
    }

    public Environment SampleSizeCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleSizeCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleSizeCode));
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
