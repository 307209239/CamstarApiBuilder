// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResourceTypeMaintService : UserCodeMaintBase
  {
    public ResourceTypeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResourceTypeMaintService), userProfile);
    }

    public ResultStatus Delete(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      result = (ResourceTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTypeMaintService) this._Channel).Delete(this._UserProfile, resourceTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceTypeMaintMethod(resourceTypeMaint, ResourceTypeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ResourceTypeMaint) null, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus Delete(ResourceTypeMaint resourceTypeMaint)
    {
      return this.Delete(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus Delete(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      return this.Delete(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      result = (ResourceTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTypeMaintService) this._Channel).Freeze(this._UserProfile, resourceTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceTypeMaintMethod(resourceTypeMaint, ResourceTypeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ResourceTypeMaint) null, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus Freeze(ResourceTypeMaint resourceTypeMaint)
    {
      return this.Freeze(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus Freeze(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      return this.Freeze(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      result = (ResourceTypeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTypeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, resourceTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceTypeMaintMethod(resourceTypeMaint, ResourceTypeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResourceTypeMaint) null, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ResourceTypeMaint resourceTypeMaint)
    {
      return this.GetWIPMsgs(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      return this.GetWIPMsgs(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      result = (ResourceTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTypeMaintService) this._Channel).Load(this._UserProfile, resourceTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceTypeMaintMethod(resourceTypeMaint, ResourceTypeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResourceTypeMaint) null, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus Load(ResourceTypeMaint resourceTypeMaint)
    {
      return this.Load(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus Load(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      return this.Load(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_LoadESigDetails_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      result = (ResourceTypeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTypeMaintService) this._Channel).LoadESigDetails(this._UserProfile, resourceTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceTypeMaintMethod(resourceTypeMaint, ResourceTypeMaintMethods.LoadESigDetails, (ResourceTypeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResourceTypeMaint) null, (ResourceTypeMaint_LoadESigDetails_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ResourceTypeMaint resourceTypeMaint)
    {
      return this.LoadESigDetails(resourceTypeMaint, (ResourceTypeMaint_LoadESigDetails_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      return this.LoadESigDetails(resourceTypeMaint, (ResourceTypeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      result = (ResourceTypeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTypeMaintService) this._Channel).New(this._UserProfile, resourceTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceTypeMaintMethod(resourceTypeMaint, ResourceTypeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ResourceTypeMaint) null, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus New(ResourceTypeMaint resourceTypeMaint)
    {
      return this.New(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus New(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      return this.New(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      result = (ResourceTypeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTypeMaintService) this._Channel).NewCopy(this._UserProfile, resourceTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceTypeMaintMethod(resourceTypeMaint, ResourceTypeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ResourceTypeMaint) null, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus NewCopy(ResourceTypeMaint resourceTypeMaint)
    {
      return this.NewCopy(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus NewCopy(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      return this.NewCopy(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      result = (ResourceTypeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTypeMaintService) this._Channel).SaveAs(this._UserProfile, resourceTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceTypeMaintMethod(resourceTypeMaint, ResourceTypeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ResourceTypeMaint) null, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus SaveAs(ResourceTypeMaint resourceTypeMaint)
    {
      return this.SaveAs(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus SaveAs(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      return this.SaveAs(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Parameters parameters,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      result = (ResourceTypeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTypeMaintService) this._Channel).UnFreeze(this._UserProfile, resourceTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceTypeMaintMethod(resourceTypeMaint, ResourceTypeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) resourceTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ResourceTypeMaint) null, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(ResourceTypeMaint resourceTypeMaint)
    {
      return this.UnFreeze(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ResourceTypeMaint resourceTypeMaint,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      return this.UnFreeze(resourceTypeMaint, (ResourceTypeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject resourceTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTypeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ResourceTypeMaint) resourceTypeMaint, (ResourceTypeMaint_Parameters) parameters, (ResourceTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject resourceTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTypeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ResourceTypeMaint) resourceTypeMaint, (ResourceTypeMaint_Parameters) parameters, (ResourceTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resourceTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTypeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResourceTypeMaint) resourceTypeMaint, (ResourceTypeMaint_LoadESigDetails_Parameters) parameters, (ResourceTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject resourceTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTypeMaint_Result result1;
        ResultStatus resultStatus = this.New((ResourceTypeMaint) resourceTypeMaint, (ResourceTypeMaint_Parameters) parameters, (ResourceTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject resourceTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTypeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ResourceTypeMaint) resourceTypeMaint, (ResourceTypeMaint_Parameters) parameters, (ResourceTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject resourceTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTypeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ResourceTypeMaint) resourceTypeMaint, (ResourceTypeMaint_Parameters) parameters, (ResourceTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject resourceTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTypeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ResourceTypeMaint) resourceTypeMaint, (ResourceTypeMaint_Parameters) parameters, (ResourceTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resourceTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTypeMaint_Result result1;
        ResultStatus resultStatus = this.Load((ResourceTypeMaint) resourceTypeMaint, (ResourceTypeMaint_Parameters) parameters, (ResourceTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resourceTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceTypeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResourceTypeMaint) resourceTypeMaint, (ResourceTypeMaint_Parameters) parameters, (ResourceTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      result = (ResourceTypeMaint_Result) null;
      try
      {
        ResourceTypeMaintMethod[] methods = new ResourceTypeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResourceTypeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResourceTypeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResourceTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceTypeMaint cdo,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      result = (ResourceTypeMaint_Result) null;
      try
      {
        return ((IResourceTypeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResourceTypeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ResourceTypeMaint) cdo, (ResourceTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      return this.GetEnvironment((ResourceTypeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResourceTypeMaint cdo,
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      result = (ResourceTypeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceTypeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResourceTypeMaintMethod(cdo, ResourceTypeMaintMethods.ExecuteTransaction, (ResourceTypeMaint_Parameters) null));
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
        ResourceTypeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResourceTypeMaint) cdo, (ResourceTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResourceTypeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ResourceTypeMaint_Request) null, out ResourceTypeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResourceTypeMaint_Request request,
      out ResourceTypeMaint_Result result)
    {
      return this.ExecuteTransaction((ResourceTypeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResourceTypeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResourceTypeMaintMethod(cdo, ResourceTypeMaintMethods.AddDataTransaction, (ResourceTypeMaint_Parameters) null));
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
        return this.AddDataTransaction((ResourceTypeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
