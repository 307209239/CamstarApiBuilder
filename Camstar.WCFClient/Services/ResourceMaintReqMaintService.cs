// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceMaintReqMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResourceMaintReqMaintService : AssignedMaintReqMaintBase
  {
    public ResourceMaintReqMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResourceMaintReqMaintService), userProfile);
    }

    public ResultStatus Delete(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      result = (ResourceMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintReqMaintService) this._Channel).Delete(this._UserProfile, resourceMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintReqMaintMethod(resourceMaintReqMaint, ResourceMaintReqMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ResourceMaintReqMaint) null, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus Delete(ResourceMaintReqMaint resourceMaintReqMaint)
    {
      return this.Delete(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus Delete(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      return this.Delete(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      result = (ResourceMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintReqMaintService) this._Channel).Freeze(this._UserProfile, resourceMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintReqMaintMethod(resourceMaintReqMaint, ResourceMaintReqMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ResourceMaintReqMaint) null, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus Freeze(ResourceMaintReqMaint resourceMaintReqMaint)
    {
      return this.Freeze(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus Freeze(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      return this.Freeze(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      result = (ResourceMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintReqMaintService) this._Channel).GetWIPMsgs(this._UserProfile, resourceMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintReqMaintMethod(resourceMaintReqMaint, ResourceMaintReqMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResourceMaintReqMaint) null, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ResourceMaintReqMaint resourceMaintReqMaint)
    {
      return this.GetWIPMsgs(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      return this.GetWIPMsgs(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      result = (ResourceMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintReqMaintService) this._Channel).Load(this._UserProfile, resourceMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintReqMaintMethod(resourceMaintReqMaint, ResourceMaintReqMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResourceMaintReqMaint) null, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus Load(ResourceMaintReqMaint resourceMaintReqMaint)
    {
      return this.Load(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus Load(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      return this.Load(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_LoadESigDetails_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      result = (ResourceMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintReqMaintService) this._Channel).LoadESigDetails(this._UserProfile, resourceMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintReqMaintMethod(resourceMaintReqMaint, ResourceMaintReqMaintMethods.LoadESigDetails, (ResourceMaintReqMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResourceMaintReqMaint) null, (ResourceMaintReqMaint_LoadESigDetails_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ResourceMaintReqMaint resourceMaintReqMaint)
    {
      return this.LoadESigDetails(resourceMaintReqMaint, (ResourceMaintReqMaint_LoadESigDetails_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      return this.LoadESigDetails(resourceMaintReqMaint, (ResourceMaintReqMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      result = (ResourceMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintReqMaintService) this._Channel).New(this._UserProfile, resourceMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintReqMaintMethod(resourceMaintReqMaint, ResourceMaintReqMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ResourceMaintReqMaint) null, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus New(ResourceMaintReqMaint resourceMaintReqMaint)
    {
      return this.New(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus New(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      return this.New(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      result = (ResourceMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintReqMaintService) this._Channel).NewCopy(this._UserProfile, resourceMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintReqMaintMethod(resourceMaintReqMaint, ResourceMaintReqMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ResourceMaintReqMaint) null, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus NewCopy(ResourceMaintReqMaint resourceMaintReqMaint)
    {
      return this.NewCopy(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus NewCopy(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      return this.NewCopy(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      result = (ResourceMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintReqMaintService) this._Channel).SaveAs(this._UserProfile, resourceMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintReqMaintMethod(resourceMaintReqMaint, ResourceMaintReqMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ResourceMaintReqMaint) null, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus SaveAs(ResourceMaintReqMaint resourceMaintReqMaint)
    {
      return this.SaveAs(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus SaveAs(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      return this.SaveAs(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Parameters parameters,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      result = (ResourceMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintReqMaintService) this._Channel).UnFreeze(this._UserProfile, resourceMaintReqMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceMaintReqMaintMethod(resourceMaintReqMaint, ResourceMaintReqMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) resourceMaintReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ResourceMaintReqMaint) null, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus UnFreeze(ResourceMaintReqMaint resourceMaintReqMaint)
    {
      return this.UnFreeze(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ResourceMaintReqMaint resourceMaintReqMaint,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      return this.UnFreeze(resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject resourceMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ResourceMaintReqMaint) resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) parameters, (ResourceMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject resourceMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ResourceMaintReqMaint) resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) parameters, (ResourceMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resourceMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResourceMaintReqMaint) resourceMaintReqMaint, (ResourceMaintReqMaint_LoadESigDetails_Parameters) parameters, (ResourceMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject resourceMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.New((ResourceMaintReqMaint) resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) parameters, (ResourceMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject resourceMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ResourceMaintReqMaint) resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) parameters, (ResourceMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject resourceMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ResourceMaintReqMaint) resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) parameters, (ResourceMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject resourceMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ResourceMaintReqMaint) resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) parameters, (ResourceMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resourceMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.Load((ResourceMaintReqMaint) resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) parameters, (ResourceMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resourceMaintReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceMaintReqMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResourceMaintReqMaint) resourceMaintReqMaint, (ResourceMaintReqMaint_Parameters) parameters, (ResourceMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      result = (ResourceMaintReqMaint_Result) null;
      try
      {
        ResourceMaintReqMaintMethod[] methods = new ResourceMaintReqMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResourceMaintReqMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResourceMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResourceMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceMaintReqMaint cdo,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      result = (ResourceMaintReqMaint_Result) null;
      try
      {
        return ((IResourceMaintReqMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResourceMaintReqMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ResourceMaintReqMaint) cdo, (ResourceMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      return this.GetEnvironment((ResourceMaintReqMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResourceMaintReqMaint cdo,
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      result = (ResourceMaintReqMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceMaintReqMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResourceMaintReqMaintMethod(cdo, ResourceMaintReqMaintMethods.ExecuteTransaction, (ResourceMaintReqMaint_Parameters) null));
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
        ResourceMaintReqMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResourceMaintReqMaint) cdo, (ResourceMaintReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResourceMaintReqMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ResourceMaintReqMaint_Request) null, out ResourceMaintReqMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResourceMaintReqMaint_Request request,
      out ResourceMaintReqMaint_Result result)
    {
      return this.ExecuteTransaction((ResourceMaintReqMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResourceMaintReqMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResourceMaintReqMaintMethod(cdo, ResourceMaintReqMaintMethods.AddDataTransaction, (ResourceMaintReqMaint_Parameters) null));
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
        return this.AddDataTransaction((ResourceMaintReqMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
