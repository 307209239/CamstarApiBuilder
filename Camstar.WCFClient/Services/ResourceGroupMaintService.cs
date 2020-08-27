// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResourceGroupMaintService : NamedObjectGroupMaintBase
  {
    public ResourceGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResourceGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      result = (ResourceGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceGroupMaintService) this._Channel).Delete(this._UserProfile, resourceGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceGroupMaintMethod(resourceGroupMaint, ResourceGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ResourceGroupMaint) null, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus Delete(ResourceGroupMaint resourceGroupMaint)
    {
      return this.Delete(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus Delete(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      return this.Delete(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      result = (ResourceGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceGroupMaintService) this._Channel).Freeze(this._UserProfile, resourceGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceGroupMaintMethod(resourceGroupMaint, ResourceGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ResourceGroupMaint) null, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus Freeze(ResourceGroupMaint resourceGroupMaint)
    {
      return this.Freeze(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      return this.Freeze(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      result = (ResourceGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, resourceGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceGroupMaintMethod(resourceGroupMaint, ResourceGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResourceGroupMaint) null, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ResourceGroupMaint resourceGroupMaint)
    {
      return this.GetWIPMsgs(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      return this.GetWIPMsgs(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      result = (ResourceGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceGroupMaintService) this._Channel).Load(this._UserProfile, resourceGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceGroupMaintMethod(resourceGroupMaint, ResourceGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResourceGroupMaint) null, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus Load(ResourceGroupMaint resourceGroupMaint)
    {
      return this.Load(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus Load(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      return this.Load(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_LoadESigDetails_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      result = (ResourceGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, resourceGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceGroupMaintMethod(resourceGroupMaint, ResourceGroupMaintMethods.LoadESigDetails, (ResourceGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResourceGroupMaint) null, (ResourceGroupMaint_LoadESigDetails_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ResourceGroupMaint resourceGroupMaint)
    {
      return this.LoadESigDetails(resourceGroupMaint, (ResourceGroupMaint_LoadESigDetails_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      return this.LoadESigDetails(resourceGroupMaint, (ResourceGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      result = (ResourceGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceGroupMaintService) this._Channel).New(this._UserProfile, resourceGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceGroupMaintMethod(resourceGroupMaint, ResourceGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ResourceGroupMaint) null, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus New(ResourceGroupMaint resourceGroupMaint)
    {
      return this.New(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus New(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      return this.New(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      result = (ResourceGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceGroupMaintService) this._Channel).NewCopy(this._UserProfile, resourceGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceGroupMaintMethod(resourceGroupMaint, ResourceGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ResourceGroupMaint) null, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus NewCopy(ResourceGroupMaint resourceGroupMaint)
    {
      return this.NewCopy(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      return this.NewCopy(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      result = (ResourceGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceGroupMaintService) this._Channel).SaveAs(this._UserProfile, resourceGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceGroupMaintMethod(resourceGroupMaint, ResourceGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ResourceGroupMaint) null, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus SaveAs(ResourceGroupMaint resourceGroupMaint)
    {
      return this.SaveAs(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      return this.SaveAs(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Parameters parameters,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      result = (ResourceGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceGroupMaintService) this._Channel).UnFreeze(this._UserProfile, resourceGroupMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceGroupMaintMethod(resourceGroupMaint, ResourceGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) resourceGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ResourceGroupMaint) null, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(ResourceGroupMaint resourceGroupMaint)
    {
      return this.UnFreeze(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ResourceGroupMaint resourceGroupMaint,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      return this.UnFreeze(resourceGroupMaint, (ResourceGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject resourceGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ResourceGroupMaint) resourceGroupMaint, (ResourceGroupMaint_Parameters) parameters, (ResourceGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject resourceGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ResourceGroupMaint) resourceGroupMaint, (ResourceGroupMaint_Parameters) parameters, (ResourceGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resourceGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResourceGroupMaint) resourceGroupMaint, (ResourceGroupMaint_LoadESigDetails_Parameters) parameters, (ResourceGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject resourceGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((ResourceGroupMaint) resourceGroupMaint, (ResourceGroupMaint_Parameters) parameters, (ResourceGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject resourceGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ResourceGroupMaint) resourceGroupMaint, (ResourceGroupMaint_Parameters) parameters, (ResourceGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject resourceGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ResourceGroupMaint) resourceGroupMaint, (ResourceGroupMaint_Parameters) parameters, (ResourceGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject resourceGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ResourceGroupMaint) resourceGroupMaint, (ResourceGroupMaint_Parameters) parameters, (ResourceGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resourceGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((ResourceGroupMaint) resourceGroupMaint, (ResourceGroupMaint_Parameters) parameters, (ResourceGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resourceGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResourceGroupMaint) resourceGroupMaint, (ResourceGroupMaint_Parameters) parameters, (ResourceGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      result = (ResourceGroupMaint_Result) null;
      try
      {
        ResourceGroupMaintMethod[] methods = new ResourceGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResourceGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResourceGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResourceGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceGroupMaint cdo,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      result = (ResourceGroupMaint_Result) null;
      try
      {
        return ((IResourceGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResourceGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ResourceGroupMaint) cdo, (ResourceGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      return this.GetEnvironment((ResourceGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResourceGroupMaint cdo,
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      result = (ResourceGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResourceGroupMaintMethod(cdo, ResourceGroupMaintMethods.ExecuteTransaction, (ResourceGroupMaint_Parameters) null));
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
        ResourceGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResourceGroupMaint) cdo, (ResourceGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResourceGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ResourceGroupMaint_Request) null, out ResourceGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResourceGroupMaint_Request request,
      out ResourceGroupMaint_Result result)
    {
      return this.ExecuteTransaction((ResourceGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResourceGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResourceGroupMaintMethod(cdo, ResourceGroupMaintMethods.AddDataTransaction, (ResourceGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((ResourceGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
