// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceStatusCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResourceStatusCodeMaintService : UserCodeMaintBase
  {
    public ResourceStatusCodeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResourceStatusCodeMaintService), userProfile);
    }

    public ResultStatus Delete(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      result = (ResourceStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusCodeMaintService) this._Channel).Delete(this._UserProfile, resourceStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusCodeMaintMethod(resourceStatusCodeMaint, ResourceStatusCodeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ResourceStatusCodeMaint) null, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus Delete(ResourceStatusCodeMaint resourceStatusCodeMaint)
    {
      return this.Delete(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus Delete(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      return this.Delete(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      result = (ResourceStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusCodeMaintService) this._Channel).Freeze(this._UserProfile, resourceStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusCodeMaintMethod(resourceStatusCodeMaint, ResourceStatusCodeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ResourceStatusCodeMaint) null, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus Freeze(ResourceStatusCodeMaint resourceStatusCodeMaint)
    {
      return this.Freeze(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus Freeze(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      return this.Freeze(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      result = (ResourceStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusCodeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, resourceStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusCodeMaintMethod(resourceStatusCodeMaint, ResourceStatusCodeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResourceStatusCodeMaint) null, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ResourceStatusCodeMaint resourceStatusCodeMaint)
    {
      return this.GetWIPMsgs(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      return this.GetWIPMsgs(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      result = (ResourceStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusCodeMaintService) this._Channel).Load(this._UserProfile, resourceStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusCodeMaintMethod(resourceStatusCodeMaint, ResourceStatusCodeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResourceStatusCodeMaint) null, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus Load(ResourceStatusCodeMaint resourceStatusCodeMaint)
    {
      return this.Load(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus Load(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      return this.Load(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_LoadESigDetails_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      result = (ResourceStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusCodeMaintService) this._Channel).LoadESigDetails(this._UserProfile, resourceStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusCodeMaintMethod(resourceStatusCodeMaint, ResourceStatusCodeMaintMethods.LoadESigDetails, (ResourceStatusCodeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResourceStatusCodeMaint) null, (ResourceStatusCodeMaint_LoadESigDetails_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ResourceStatusCodeMaint resourceStatusCodeMaint)
    {
      return this.LoadESigDetails(resourceStatusCodeMaint, (ResourceStatusCodeMaint_LoadESigDetails_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      return this.LoadESigDetails(resourceStatusCodeMaint, (ResourceStatusCodeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      result = (ResourceStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusCodeMaintService) this._Channel).New(this._UserProfile, resourceStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusCodeMaintMethod(resourceStatusCodeMaint, ResourceStatusCodeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ResourceStatusCodeMaint) null, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus New(ResourceStatusCodeMaint resourceStatusCodeMaint)
    {
      return this.New(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus New(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      return this.New(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      result = (ResourceStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusCodeMaintService) this._Channel).NewCopy(this._UserProfile, resourceStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusCodeMaintMethod(resourceStatusCodeMaint, ResourceStatusCodeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ResourceStatusCodeMaint) null, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus NewCopy(ResourceStatusCodeMaint resourceStatusCodeMaint)
    {
      return this.NewCopy(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus NewCopy(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      return this.NewCopy(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      result = (ResourceStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusCodeMaintService) this._Channel).SaveAs(this._UserProfile, resourceStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusCodeMaintMethod(resourceStatusCodeMaint, ResourceStatusCodeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ResourceStatusCodeMaint) null, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus SaveAs(ResourceStatusCodeMaint resourceStatusCodeMaint)
    {
      return this.SaveAs(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus SaveAs(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      return this.SaveAs(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Parameters parameters,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      result = (ResourceStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusCodeMaintService) this._Channel).UnFreeze(this._UserProfile, resourceStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusCodeMaintMethod(resourceStatusCodeMaint, ResourceStatusCodeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) resourceStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ResourceStatusCodeMaint) null, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(ResourceStatusCodeMaint resourceStatusCodeMaint)
    {
      return this.UnFreeze(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ResourceStatusCodeMaint resourceStatusCodeMaint,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      return this.UnFreeze(resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject resourceStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ResourceStatusCodeMaint) resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) parameters, (ResourceStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject resourceStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ResourceStatusCodeMaint) resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) parameters, (ResourceStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resourceStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResourceStatusCodeMaint) resourceStatusCodeMaint, (ResourceStatusCodeMaint_LoadESigDetails_Parameters) parameters, (ResourceStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject resourceStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.New((ResourceStatusCodeMaint) resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) parameters, (ResourceStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject resourceStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ResourceStatusCodeMaint) resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) parameters, (ResourceStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject resourceStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ResourceStatusCodeMaint) resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) parameters, (ResourceStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject resourceStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ResourceStatusCodeMaint) resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) parameters, (ResourceStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resourceStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.Load((ResourceStatusCodeMaint) resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) parameters, (ResourceStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resourceStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusCodeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResourceStatusCodeMaint) resourceStatusCodeMaint, (ResourceStatusCodeMaint_Parameters) parameters, (ResourceStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      result = (ResourceStatusCodeMaint_Result) null;
      try
      {
        ResourceStatusCodeMaintMethod[] methods = new ResourceStatusCodeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResourceStatusCodeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResourceStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResourceStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceStatusCodeMaint cdo,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      result = (ResourceStatusCodeMaint_Result) null;
      try
      {
        return ((IResourceStatusCodeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResourceStatusCodeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ResourceStatusCodeMaint) cdo, (ResourceStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      return this.GetEnvironment((ResourceStatusCodeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResourceStatusCodeMaint cdo,
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      result = (ResourceStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusCodeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResourceStatusCodeMaintMethod(cdo, ResourceStatusCodeMaintMethods.ExecuteTransaction, (ResourceStatusCodeMaint_Parameters) null));
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
        ResourceStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResourceStatusCodeMaint) cdo, (ResourceStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResourceStatusCodeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ResourceStatusCodeMaint_Request) null, out ResourceStatusCodeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResourceStatusCodeMaint_Request request,
      out ResourceStatusCodeMaint_Result result)
    {
      return this.ExecuteTransaction((ResourceStatusCodeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResourceStatusCodeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResourceStatusCodeMaintMethod(cdo, ResourceStatusCodeMaintMethods.AddDataTransaction, (ResourceStatusCodeMaint_Parameters) null));
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
        return this.AddDataTransaction((ResourceStatusCodeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
