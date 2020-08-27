// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceStatusReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResourceStatusReasonMaintService : UserCodeMaintBase
  {
    public ResourceStatusReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResourceStatusReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Parameters parameters,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      result = (ResourceStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusReasonMaintService) this._Channel).Delete(this._UserProfile, resourceStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusReasonMaintMethod(resourceStatusReasonMaint, ResourceStatusReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ResourceStatusReasonMaint) null, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus Delete(
      ResourceStatusReasonMaint resourceStatusReasonMaint)
    {
      return this.Delete(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus Delete(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      return this.Delete(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Parameters parameters,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      result = (ResourceStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusReasonMaintService) this._Channel).Freeze(this._UserProfile, resourceStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusReasonMaintMethod(resourceStatusReasonMaint, ResourceStatusReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ResourceStatusReasonMaint) null, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      ResourceStatusReasonMaint resourceStatusReasonMaint)
    {
      return this.Freeze(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      return this.Freeze(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Parameters parameters,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      result = (ResourceStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, resourceStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusReasonMaintMethod(resourceStatusReasonMaint, ResourceStatusReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResourceStatusReasonMaint) null, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceStatusReasonMaint resourceStatusReasonMaint)
    {
      return this.GetWIPMsgs(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      return this.GetWIPMsgs(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Parameters parameters,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      result = (ResourceStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusReasonMaintService) this._Channel).Load(this._UserProfile, resourceStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusReasonMaintMethod(resourceStatusReasonMaint, ResourceStatusReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResourceStatusReasonMaint) null, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus Load(
      ResourceStatusReasonMaint resourceStatusReasonMaint)
    {
      return this.Load(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus Load(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      return this.Load(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_LoadESigDetails_Parameters parameters,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      result = (ResourceStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, resourceStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusReasonMaintMethod(resourceStatusReasonMaint, ResourceStatusReasonMaintMethods.LoadESigDetails, (ResourceStatusReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResourceStatusReasonMaint) null, (ResourceStatusReasonMaint_LoadESigDetails_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceStatusReasonMaint resourceStatusReasonMaint)
    {
      return this.LoadESigDetails(resourceStatusReasonMaint, (ResourceStatusReasonMaint_LoadESigDetails_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      return this.LoadESigDetails(resourceStatusReasonMaint, (ResourceStatusReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Parameters parameters,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      result = (ResourceStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusReasonMaintService) this._Channel).New(this._UserProfile, resourceStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusReasonMaintMethod(resourceStatusReasonMaint, ResourceStatusReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ResourceStatusReasonMaint) null, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus New(
      ResourceStatusReasonMaint resourceStatusReasonMaint)
    {
      return this.New(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus New(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      return this.New(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Parameters parameters,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      result = (ResourceStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusReasonMaintService) this._Channel).NewCopy(this._UserProfile, resourceStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusReasonMaintMethod(resourceStatusReasonMaint, ResourceStatusReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ResourceStatusReasonMaint) null, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      ResourceStatusReasonMaint resourceStatusReasonMaint)
    {
      return this.NewCopy(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      return this.NewCopy(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Parameters parameters,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      result = (ResourceStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusReasonMaintService) this._Channel).SaveAs(this._UserProfile, resourceStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusReasonMaintMethod(resourceStatusReasonMaint, ResourceStatusReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ResourceStatusReasonMaint) null, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      ResourceStatusReasonMaint resourceStatusReasonMaint)
    {
      return this.SaveAs(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      return this.SaveAs(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Parameters parameters,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      result = (ResourceStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusReasonMaintService) this._Channel).UnFreeze(this._UserProfile, resourceStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusReasonMaintMethod(resourceStatusReasonMaint, ResourceStatusReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) resourceStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ResourceStatusReasonMaint) null, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ResourceStatusReasonMaint resourceStatusReasonMaint)
    {
      return this.UnFreeze(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ResourceStatusReasonMaint resourceStatusReasonMaint,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      return this.UnFreeze(resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject resourceStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ResourceStatusReasonMaint) resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) parameters, (ResourceStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject resourceStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ResourceStatusReasonMaint) resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) parameters, (ResourceStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resourceStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResourceStatusReasonMaint) resourceStatusReasonMaint, (ResourceStatusReasonMaint_LoadESigDetails_Parameters) parameters, (ResourceStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject resourceStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((ResourceStatusReasonMaint) resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) parameters, (ResourceStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject resourceStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ResourceStatusReasonMaint) resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) parameters, (ResourceStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject resourceStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ResourceStatusReasonMaint) resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) parameters, (ResourceStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject resourceStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ResourceStatusReasonMaint) resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) parameters, (ResourceStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resourceStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((ResourceStatusReasonMaint) resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) parameters, (ResourceStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resourceStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResourceStatusReasonMaint) resourceStatusReasonMaint, (ResourceStatusReasonMaint_Parameters) parameters, (ResourceStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      result = (ResourceStatusReasonMaint_Result) null;
      try
      {
        ResourceStatusReasonMaintMethod[] methods = new ResourceStatusReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResourceStatusReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResourceStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResourceStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceStatusReasonMaint cdo,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      result = (ResourceStatusReasonMaint_Result) null;
      try
      {
        return ((IResourceStatusReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResourceStatusReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ResourceStatusReasonMaint) cdo, (ResourceStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      return this.GetEnvironment((ResourceStatusReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResourceStatusReasonMaint cdo,
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      result = (ResourceStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResourceStatusReasonMaintMethod(cdo, ResourceStatusReasonMaintMethods.ExecuteTransaction, (ResourceStatusReasonMaint_Parameters) null));
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
        ResourceStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResourceStatusReasonMaint) cdo, (ResourceStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResourceStatusReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ResourceStatusReasonMaint_Request) null, out ResourceStatusReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResourceStatusReasonMaint_Request request,
      out ResourceStatusReasonMaint_Result result)
    {
      return this.ExecuteTransaction((ResourceStatusReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResourceStatusReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResourceStatusReasonMaintMethod(cdo, ResourceStatusReasonMaintMethods.AddDataTransaction, (ResourceStatusReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((ResourceStatusReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
