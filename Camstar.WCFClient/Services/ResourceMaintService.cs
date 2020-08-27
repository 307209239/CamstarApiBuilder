// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResourceMaintService : NamedDataObjectMaintBase
  {
    public ResourceMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResourceMaintService), userProfile);
    }

    public ResultStatus CheckAssignedReqs(
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      this.OnBeforeCall(nameof (CheckAssignedReqs), (DCObject) resourceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintService) this._Channel).CheckAssignedReqs(this._UserProfile, resourceMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintMethod(resourceMaint, ResourceMaintMethods.CheckAssignedReqs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CheckAssignedReqs), res, (DCObject) resourceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CheckAssignedReqs()
    {
      return this.CheckAssignedReqs((ResourceMaint) null, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus CheckAssignedReqs(ResourceMaint resourceMaint)
    {
      return this.CheckAssignedReqs(resourceMaint, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus CheckAssignedReqs(
      ResourceMaint resourceMaint,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      return this.CheckAssignedReqs(resourceMaint, (ResourceMaint_Parameters) null, request, out result);
    }

    public ResultStatus CreateMaintenanceStatuses(
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      this.OnBeforeCall(nameof (CreateMaintenanceStatuses), (DCObject) resourceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintService) this._Channel).CreateMaintenanceStatuses(this._UserProfile, resourceMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintMethod(resourceMaint, ResourceMaintMethods.CreateMaintenanceStatuses, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateMaintenanceStatuses), res, (DCObject) resourceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateMaintenanceStatuses()
    {
      return this.CreateMaintenanceStatuses((ResourceMaint) null, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus CreateMaintenanceStatuses(ResourceMaint resourceMaint)
    {
      return this.CreateMaintenanceStatuses(resourceMaint, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus CreateMaintenanceStatuses(
      ResourceMaint resourceMaint,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      return this.CreateMaintenanceStatuses(resourceMaint, (ResourceMaint_Parameters) null, request, out result);
    }

    public ResultStatus Delete(
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) resourceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintService) this._Channel).Delete(this._UserProfile, resourceMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintMethod(resourceMaint, ResourceMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) resourceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ResourceMaint) null, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus Delete(ResourceMaint resourceMaint)
    {
      return this.Delete(resourceMaint, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus Delete(
      ResourceMaint resourceMaint,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      return this.Delete(resourceMaint, (ResourceMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) resourceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintService) this._Channel).Freeze(this._UserProfile, resourceMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintMethod(resourceMaint, ResourceMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) resourceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ResourceMaint) null, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus Freeze(ResourceMaint resourceMaint)
    {
      return this.Freeze(resourceMaint, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus Freeze(
      ResourceMaint resourceMaint,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      return this.Freeze(resourceMaint, (ResourceMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resourceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintService) this._Channel).GetWIPMsgs(this._UserProfile, resourceMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintMethod(resourceMaint, ResourceMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resourceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResourceMaint) null, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ResourceMaint resourceMaint)
    {
      return this.GetWIPMsgs(resourceMaint, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceMaint resourceMaint,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      return this.GetWIPMsgs(resourceMaint, (ResourceMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resourceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintService) this._Channel).Load(this._UserProfile, resourceMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintMethod(resourceMaint, ResourceMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resourceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResourceMaint) null, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus Load(ResourceMaint resourceMaint)
    {
      return this.Load(resourceMaint, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus Load(
      ResourceMaint resourceMaint,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      return this.Load(resourceMaint, (ResourceMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResourceMaint resourceMaint,
      ResourceMaint_LoadESigDetails_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resourceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintService) this._Channel).LoadESigDetails(this._UserProfile, resourceMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintMethod(resourceMaint, ResourceMaintMethods.LoadESigDetails, (ResourceMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resourceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResourceMaint) null, (ResourceMaint_LoadESigDetails_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ResourceMaint resourceMaint)
    {
      return this.LoadESigDetails(resourceMaint, (ResourceMaint_LoadESigDetails_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceMaint resourceMaint,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      return this.LoadESigDetails(resourceMaint, (ResourceMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) resourceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintService) this._Channel).New(this._UserProfile, resourceMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintMethod(resourceMaint, ResourceMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) resourceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ResourceMaint) null, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus New(ResourceMaint resourceMaint)
    {
      return this.New(resourceMaint, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus New(
      ResourceMaint resourceMaint,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      return this.New(resourceMaint, (ResourceMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) resourceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintService) this._Channel).NewCopy(this._UserProfile, resourceMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintMethod(resourceMaint, ResourceMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) resourceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ResourceMaint) null, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus NewCopy(ResourceMaint resourceMaint)
    {
      return this.NewCopy(resourceMaint, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus NewCopy(
      ResourceMaint resourceMaint,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      return this.NewCopy(resourceMaint, (ResourceMaint_Parameters) null, request, out result);
    }

    public ResultStatus RemoveMaintenanceStatuses(
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      this.OnBeforeCall(nameof (RemoveMaintenanceStatuses), (DCObject) resourceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintService) this._Channel).RemoveMaintenanceStatuses(this._UserProfile, resourceMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintMethod(resourceMaint, ResourceMaintMethods.RemoveMaintenanceStatuses, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RemoveMaintenanceStatuses), res, (DCObject) resourceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RemoveMaintenanceStatuses()
    {
      return this.RemoveMaintenanceStatuses((ResourceMaint) null, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus RemoveMaintenanceStatuses(ResourceMaint resourceMaint)
    {
      return this.RemoveMaintenanceStatuses(resourceMaint, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus RemoveMaintenanceStatuses(
      ResourceMaint resourceMaint,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      return this.RemoveMaintenanceStatuses(resourceMaint, (ResourceMaint_Parameters) null, request, out result);
    }

    public ResultStatus ResetResourceUOM(
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      this.OnBeforeCall(nameof (ResetResourceUOM), (DCObject) resourceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintService) this._Channel).ResetResourceUOM(this._UserProfile, resourceMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintMethod(resourceMaint, ResourceMaintMethods.ResetResourceUOM, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResetResourceUOM), res, (DCObject) resourceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResetResourceUOM()
    {
      return this.ResetResourceUOM((ResourceMaint) null, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus ResetResourceUOM(ResourceMaint resourceMaint)
    {
      return this.ResetResourceUOM(resourceMaint, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus ResetResourceUOM(
      ResourceMaint resourceMaint,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      return this.ResetResourceUOM(resourceMaint, (ResourceMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) resourceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintService) this._Channel).SaveAs(this._UserProfile, resourceMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintMethod(resourceMaint, ResourceMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) resourceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ResourceMaint) null, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus SaveAs(ResourceMaint resourceMaint)
    {
      return this.SaveAs(resourceMaint, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus SaveAs(
      ResourceMaint resourceMaint,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      return this.SaveAs(resourceMaint, (ResourceMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ResourceMaint resourceMaint,
      ResourceMaint_Parameters parameters,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) resourceMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintService) this._Channel).UnFreeze(this._UserProfile, resourceMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintMethod(resourceMaint, ResourceMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) resourceMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ResourceMaint) null, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus UnFreeze(ResourceMaint resourceMaint)
    {
      return this.UnFreeze(resourceMaint, (ResourceMaint_Parameters) null, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ResourceMaint resourceMaint,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      return this.UnFreeze(resourceMaint, (ResourceMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject resourceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ResourceMaint) resourceMaint, (ResourceMaint_Parameters) parameters, (ResourceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject resourceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ResourceMaint) resourceMaint, (ResourceMaint_Parameters) parameters, (ResourceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resourceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResourceMaint) resourceMaint, (ResourceMaint_LoadESigDetails_Parameters) parameters, (ResourceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject resourceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaint_Result result1;
        ResultStatus resultStatus = this.New((ResourceMaint) resourceMaint, (ResourceMaint_Parameters) parameters, (ResourceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject resourceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ResourceMaint) resourceMaint, (ResourceMaint_Parameters) parameters, (ResourceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject resourceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ResourceMaint) resourceMaint, (ResourceMaint_Parameters) parameters, (ResourceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject resourceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ResourceMaint) resourceMaint, (ResourceMaint_Parameters) parameters, (ResourceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resourceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaint_Result result1;
        ResultStatus resultStatus = this.Load((ResourceMaint) resourceMaint, (ResourceMaint_Parameters) parameters, (ResourceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resourceMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResourceMaint) resourceMaint, (ResourceMaint_Parameters) parameters, (ResourceMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      try
      {
        ResourceMaintMethod[] methods = new ResourceMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResourceMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResourceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceMaint cdo,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      try
      {
        return ((IResourceMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ResourceMaint) cdo, (ResourceMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      return this.GetEnvironment((ResourceMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResourceMaint cdo,
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      result = (ResourceMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResourceMaintMethod(cdo, ResourceMaintMethods.ExecuteTransaction, (ResourceMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResourceMaint) cdo, (ResourceMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResourceMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ResourceMaint_Request) null, out ResourceMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResourceMaint_Request request,
      out ResourceMaint_Result result)
    {
      return this.ExecuteTransaction((ResourceMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResourceMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResourceMaintMethod(cdo, ResourceMaintMethods.AddDataTransaction, (ResourceMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((ResourceMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
