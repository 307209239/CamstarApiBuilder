// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceStatusModelMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResourceStatusModelMaintService : NamedDataObjectMaintBase
  {
    public ResourceStatusModelMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResourceStatusModelMaintService), userProfile);
    }

    public ResultStatus Delete(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      result = (ResourceStatusModelMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusModelMaintService) this._Channel).Delete(this._UserProfile, resourceStatusModelMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusModelMaintMethod(resourceStatusModelMaint, ResourceStatusModelMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ResourceStatusModelMaint) null, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus Delete(ResourceStatusModelMaint resourceStatusModelMaint)
    {
      return this.Delete(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus Delete(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      return this.Delete(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      result = (ResourceStatusModelMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusModelMaintService) this._Channel).Freeze(this._UserProfile, resourceStatusModelMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusModelMaintMethod(resourceStatusModelMaint, ResourceStatusModelMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ResourceStatusModelMaint) null, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus Freeze(ResourceStatusModelMaint resourceStatusModelMaint)
    {
      return this.Freeze(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus Freeze(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      return this.Freeze(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      result = (ResourceStatusModelMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusModelMaintService) this._Channel).GetWIPMsgs(this._UserProfile, resourceStatusModelMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusModelMaintMethod(resourceStatusModelMaint, ResourceStatusModelMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResourceStatusModelMaint) null, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ResourceStatusModelMaint resourceStatusModelMaint)
    {
      return this.GetWIPMsgs(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      return this.GetWIPMsgs(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      result = (ResourceStatusModelMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusModelMaintService) this._Channel).Load(this._UserProfile, resourceStatusModelMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusModelMaintMethod(resourceStatusModelMaint, ResourceStatusModelMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResourceStatusModelMaint) null, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus Load(ResourceStatusModelMaint resourceStatusModelMaint)
    {
      return this.Load(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus Load(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      return this.Load(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_LoadESigDetails_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      result = (ResourceStatusModelMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusModelMaintService) this._Channel).LoadESigDetails(this._UserProfile, resourceStatusModelMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusModelMaintMethod(resourceStatusModelMaint, ResourceStatusModelMaintMethods.LoadESigDetails, (ResourceStatusModelMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResourceStatusModelMaint) null, (ResourceStatusModelMaint_LoadESigDetails_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceStatusModelMaint resourceStatusModelMaint)
    {
      return this.LoadESigDetails(resourceStatusModelMaint, (ResourceStatusModelMaint_LoadESigDetails_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      return this.LoadESigDetails(resourceStatusModelMaint, (ResourceStatusModelMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      result = (ResourceStatusModelMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusModelMaintService) this._Channel).New(this._UserProfile, resourceStatusModelMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusModelMaintMethod(resourceStatusModelMaint, ResourceStatusModelMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ResourceStatusModelMaint) null, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus New(ResourceStatusModelMaint resourceStatusModelMaint)
    {
      return this.New(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus New(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      return this.New(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      result = (ResourceStatusModelMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusModelMaintService) this._Channel).NewCopy(this._UserProfile, resourceStatusModelMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusModelMaintMethod(resourceStatusModelMaint, ResourceStatusModelMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ResourceStatusModelMaint) null, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus NewCopy(ResourceStatusModelMaint resourceStatusModelMaint)
    {
      return this.NewCopy(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus NewCopy(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      return this.NewCopy(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      result = (ResourceStatusModelMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusModelMaintService) this._Channel).SaveAs(this._UserProfile, resourceStatusModelMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusModelMaintMethod(resourceStatusModelMaint, ResourceStatusModelMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ResourceStatusModelMaint) null, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus SaveAs(ResourceStatusModelMaint resourceStatusModelMaint)
    {
      return this.SaveAs(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus SaveAs(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      return this.SaveAs(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Parameters parameters,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      result = (ResourceStatusModelMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusModelMaintService) this._Channel).UnFreeze(this._UserProfile, resourceStatusModelMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceStatusModelMaintMethod(resourceStatusModelMaint, ResourceStatusModelMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) resourceStatusModelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ResourceStatusModelMaint) null, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus UnFreeze(ResourceStatusModelMaint resourceStatusModelMaint)
    {
      return this.UnFreeze(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ResourceStatusModelMaint resourceStatusModelMaint,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      return this.UnFreeze(resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject resourceStatusModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusModelMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ResourceStatusModelMaint) resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) parameters, (ResourceStatusModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject resourceStatusModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusModelMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ResourceStatusModelMaint) resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) parameters, (ResourceStatusModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resourceStatusModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusModelMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResourceStatusModelMaint) resourceStatusModelMaint, (ResourceStatusModelMaint_LoadESigDetails_Parameters) parameters, (ResourceStatusModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject resourceStatusModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusModelMaint_Result result1;
        ResultStatus resultStatus = this.New((ResourceStatusModelMaint) resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) parameters, (ResourceStatusModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject resourceStatusModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusModelMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ResourceStatusModelMaint) resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) parameters, (ResourceStatusModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject resourceStatusModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusModelMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ResourceStatusModelMaint) resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) parameters, (ResourceStatusModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject resourceStatusModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusModelMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ResourceStatusModelMaint) resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) parameters, (ResourceStatusModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resourceStatusModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusModelMaint_Result result1;
        ResultStatus resultStatus = this.Load((ResourceStatusModelMaint) resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) parameters, (ResourceStatusModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resourceStatusModelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceStatusModelMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResourceStatusModelMaint) resourceStatusModelMaint, (ResourceStatusModelMaint_Parameters) parameters, (ResourceStatusModelMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      result = (ResourceStatusModelMaint_Result) null;
      try
      {
        ResourceStatusModelMaintMethod[] methods = new ResourceStatusModelMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResourceStatusModelMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResourceStatusModelMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResourceStatusModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceStatusModelMaint cdo,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      result = (ResourceStatusModelMaint_Result) null;
      try
      {
        return ((IResourceStatusModelMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResourceStatusModelMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ResourceStatusModelMaint) cdo, (ResourceStatusModelMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      return this.GetEnvironment((ResourceStatusModelMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResourceStatusModelMaint cdo,
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      result = (ResourceStatusModelMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceStatusModelMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResourceStatusModelMaintMethod(cdo, ResourceStatusModelMaintMethods.ExecuteTransaction, (ResourceStatusModelMaint_Parameters) null));
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
        ResourceStatusModelMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResourceStatusModelMaint) cdo, (ResourceStatusModelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResourceStatusModelMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ResourceStatusModelMaint_Request) null, out ResourceStatusModelMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResourceStatusModelMaint_Request request,
      out ResourceStatusModelMaint_Result result)
    {
      return this.ExecuteTransaction((ResourceStatusModelMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResourceStatusModelMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResourceStatusModelMaintMethod(cdo, ResourceStatusModelMaintMethods.AddDataTransaction, (ResourceStatusModelMaint_Parameters) null));
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
        return this.AddDataTransaction((ResourceStatusModelMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
