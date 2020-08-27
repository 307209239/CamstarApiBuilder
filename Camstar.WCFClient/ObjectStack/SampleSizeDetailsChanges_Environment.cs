// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SampleSizeDetailsChanges_Environment
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
  public class SampleSizeDetailsChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Environment_ListItemToChange")]
    [Metadata("Stores the Sample Sizes and reject information for specific AQL level and Sample size Code", "SampleSizeDetailsChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Stores the Sample Sizes and reject information for specific AQL level and Sample size Code", "SampleSizeDetails", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Generic String", "", false, true, false, "String", 1053167, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Environment_SampleSizeCode")]
    protected Environment _SampleSizeCode;
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Environment_Accepts")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053168, false, false, false, null)]
    protected Environment _Accepts;
    [Metadata("Generic String", "", false, true, false, "String", 1053170, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Environment_SampleSize")]
    protected Environment _SampleSize;
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1053169, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Environment_Rejects")]
    protected Environment _Rejects;
    [DataMember(EmitDefaultValue = false, Name = "SampleSizeDetailsChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 0, false, false, false, "0")]
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

    public Environment Accepts
    {
      [param: In] set
      {
        this.PropertySet(nameof (Accepts), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Accepts));
      }
    }

    public Environment SampleSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleSize), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleSize));
      }
    }

    public Environment Rejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejects), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Rejects));
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
