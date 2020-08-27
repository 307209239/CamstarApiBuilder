// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceFamilyMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResourceFamilyMaintService : NamedDataObjectMaintBase
  {
    public ResourceFamilyMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResourceFamilyMaintService), userProfile);
    }

    public ResultStatus Delete(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      result = (ResourceFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceFamilyMaintService) this._Channel).Delete(this._UserProfile, resourceFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceFamilyMaintMethod(resourceFamilyMaint, ResourceFamilyMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ResourceFamilyMaint) null, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus Delete(ResourceFamilyMaint resourceFamilyMaint)
    {
      return this.Delete(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus Delete(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      return this.Delete(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      result = (ResourceFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceFamilyMaintService) this._Channel).Freeze(this._UserProfile, resourceFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceFamilyMaintMethod(resourceFamilyMaint, ResourceFamilyMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ResourceFamilyMaint) null, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus Freeze(ResourceFamilyMaint resourceFamilyMaint)
    {
      return this.Freeze(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus Freeze(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      return this.Freeze(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      result = (ResourceFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceFamilyMaintService) this._Channel).GetWIPMsgs(this._UserProfile, resourceFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceFamilyMaintMethod(resourceFamilyMaint, ResourceFamilyMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResourceFamilyMaint) null, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ResourceFamilyMaint resourceFamilyMaint)
    {
      return this.GetWIPMsgs(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      return this.GetWIPMsgs(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      result = (ResourceFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceFamilyMaintService) this._Channel).Load(this._UserProfile, resourceFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceFamilyMaintMethod(resourceFamilyMaint, ResourceFamilyMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ResourceFamilyMaint) null, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus Load(ResourceFamilyMaint resourceFamilyMaint)
    {
      return this.Load(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus Load(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      return this.Load(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_LoadESigDetails_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      result = (ResourceFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceFamilyMaintService) this._Channel).LoadESigDetails(this._UserProfile, resourceFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceFamilyMaintMethod(resourceFamilyMaint, ResourceFamilyMaintMethods.LoadESigDetails, (ResourceFamilyMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ResourceFamilyMaint) null, (ResourceFamilyMaint_LoadESigDetails_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ResourceFamilyMaint resourceFamilyMaint)
    {
      return this.LoadESigDetails(resourceFamilyMaint, (ResourceFamilyMaint_LoadESigDetails_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      return this.LoadESigDetails(resourceFamilyMaint, (ResourceFamilyMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      result = (ResourceFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceFamilyMaintService) this._Channel).New(this._UserProfile, resourceFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceFamilyMaintMethod(resourceFamilyMaint, ResourceFamilyMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ResourceFamilyMaint) null, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus New(ResourceFamilyMaint resourceFamilyMaint)
    {
      return this.New(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus New(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      return this.New(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      result = (ResourceFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceFamilyMaintService) this._Channel).NewCopy(this._UserProfile, resourceFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceFamilyMaintMethod(resourceFamilyMaint, ResourceFamilyMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ResourceFamilyMaint) null, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus NewCopy(ResourceFamilyMaint resourceFamilyMaint)
    {
      return this.NewCopy(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus NewCopy(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      return this.NewCopy(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      result = (ResourceFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceFamilyMaintService) this._Channel).SaveAs(this._UserProfile, resourceFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceFamilyMaintMethod(resourceFamilyMaint, ResourceFamilyMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ResourceFamilyMaint) null, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus SaveAs(ResourceFamilyMaint resourceFamilyMaint)
    {
      return this.SaveAs(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus SaveAs(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      return this.SaveAs(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Parameters parameters,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      result = (ResourceFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceFamilyMaintService) this._Channel).UnFreeze(this._UserProfile, resourceFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new ResourceFamilyMaintMethod(resourceFamilyMaint, ResourceFamilyMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) resourceFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ResourceFamilyMaint) null, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus UnFreeze(ResourceFamilyMaint resourceFamilyMaint)
    {
      return this.UnFreeze(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ResourceFamilyMaint resourceFamilyMaint,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      return this.UnFreeze(resourceFamilyMaint, (ResourceFamilyMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject resourceFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceFamilyMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ResourceFamilyMaint) resourceFamilyMaint, (ResourceFamilyMaint_Parameters) parameters, (ResourceFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject resourceFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceFamilyMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ResourceFamilyMaint) resourceFamilyMaint, (ResourceFamilyMaint_Parameters) parameters, (ResourceFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject resourceFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceFamilyMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ResourceFamilyMaint) resourceFamilyMaint, (ResourceFamilyMaint_LoadESigDetails_Parameters) parameters, (ResourceFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject resourceFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceFamilyMaint_Result result1;
        ResultStatus resultStatus = this.New((ResourceFamilyMaint) resourceFamilyMaint, (ResourceFamilyMaint_Parameters) parameters, (ResourceFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject resourceFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceFamilyMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ResourceFamilyMaint) resourceFamilyMaint, (ResourceFamilyMaint_Parameters) parameters, (ResourceFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject resourceFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceFamilyMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ResourceFamilyMaint) resourceFamilyMaint, (ResourceFamilyMaint_Parameters) parameters, (ResourceFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject resourceFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceFamilyMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ResourceFamilyMaint) resourceFamilyMaint, (ResourceFamilyMaint_Parameters) parameters, (ResourceFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject resourceFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceFamilyMaint_Result result1;
        ResultStatus resultStatus = this.Load((ResourceFamilyMaint) resourceFamilyMaint, (ResourceFamilyMaint_Parameters) parameters, (ResourceFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resourceFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceFamilyMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResourceFamilyMaint) resourceFamilyMaint, (ResourceFamilyMaint_Parameters) parameters, (ResourceFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      result = (ResourceFamilyMaint_Result) null;
      try
      {
        ResourceFamilyMaintMethod[] methods = new ResourceFamilyMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResourceFamilyMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResourceFamilyMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResourceFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceFamilyMaint cdo,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      result = (ResourceFamilyMaint_Result) null;
      try
      {
        return ((IResourceFamilyMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResourceFamilyMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ResourceFamilyMaint) cdo, (ResourceFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      return this.GetEnvironment((ResourceFamilyMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResourceFamilyMaint cdo,
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      result = (ResourceFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceFamilyMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResourceFamilyMaintMethod(cdo, ResourceFamilyMaintMethods.ExecuteTransaction, (ResourceFamilyMaint_Parameters) null));
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
        ResourceFamilyMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResourceFamilyMaint) cdo, (ResourceFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResourceFamilyMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ResourceFamilyMaint_Request) null, out ResourceFamilyMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResourceFamilyMaint_Request request,
      out ResourceFamilyMaint_Result result)
    {
      return this.ExecuteTransaction((ResourceFamilyMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResourceFamilyMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResourceFamilyMaintMethod(cdo, ResourceFamilyMaintMethods.AddDataTransaction, (ResourceFamilyMaint_Parameters) null));
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
        return this.AddDataTransaction((ResourceFamilyMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
