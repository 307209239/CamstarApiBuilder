// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SubClassificationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SubClassificationMaintService : UserCodeMaintBase
  {
    public SubClassificationMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISubClassificationMaintService), userProfile);
    }

    public ResultStatus Delete(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      result = (SubClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubClassificationMaintService) this._Channel).Delete(this._UserProfile, subClassificationMaint, parameters, request, out result) : this.AddMethod((Method) new SubClassificationMaintMethod(subClassificationMaint, SubClassificationMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SubClassificationMaint) null, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus Delete(SubClassificationMaint subClassificationMaint)
    {
      return this.Delete(subClassificationMaint, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus Delete(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      return this.Delete(subClassificationMaint, (SubClassificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      result = (SubClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubClassificationMaintService) this._Channel).Freeze(this._UserProfile, subClassificationMaint, parameters, request, out result) : this.AddMethod((Method) new SubClassificationMaintMethod(subClassificationMaint, SubClassificationMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SubClassificationMaint) null, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus Freeze(SubClassificationMaint subClassificationMaint)
    {
      return this.Freeze(subClassificationMaint, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus Freeze(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      return this.Freeze(subClassificationMaint, (SubClassificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      result = (SubClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubClassificationMaintService) this._Channel).GetWIPMsgs(this._UserProfile, subClassificationMaint, parameters, request, out result) : this.AddMethod((Method) new SubClassificationMaintMethod(subClassificationMaint, SubClassificationMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SubClassificationMaint) null, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SubClassificationMaint subClassificationMaint)
    {
      return this.GetWIPMsgs(subClassificationMaint, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      return this.GetWIPMsgs(subClassificationMaint, (SubClassificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      result = (SubClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubClassificationMaintService) this._Channel).Load(this._UserProfile, subClassificationMaint, parameters, request, out result) : this.AddMethod((Method) new SubClassificationMaintMethod(subClassificationMaint, SubClassificationMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SubClassificationMaint) null, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus Load(SubClassificationMaint subClassificationMaint)
    {
      return this.Load(subClassificationMaint, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus Load(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      return this.Load(subClassificationMaint, (SubClassificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_LoadESigDetails_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      result = (SubClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubClassificationMaintService) this._Channel).LoadESigDetails(this._UserProfile, subClassificationMaint, parameters, request, out result) : this.AddMethod((Method) new SubClassificationMaintMethod(subClassificationMaint, SubClassificationMaintMethods.LoadESigDetails, (SubClassificationMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SubClassificationMaint) null, (SubClassificationMaint_LoadESigDetails_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SubClassificationMaint subClassificationMaint)
    {
      return this.LoadESigDetails(subClassificationMaint, (SubClassificationMaint_LoadESigDetails_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      return this.LoadESigDetails(subClassificationMaint, (SubClassificationMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      result = (SubClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubClassificationMaintService) this._Channel).New(this._UserProfile, subClassificationMaint, parameters, request, out result) : this.AddMethod((Method) new SubClassificationMaintMethod(subClassificationMaint, SubClassificationMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SubClassificationMaint) null, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus New(SubClassificationMaint subClassificationMaint)
    {
      return this.New(subClassificationMaint, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus New(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      return this.New(subClassificationMaint, (SubClassificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      result = (SubClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubClassificationMaintService) this._Channel).NewCopy(this._UserProfile, subClassificationMaint, parameters, request, out result) : this.AddMethod((Method) new SubClassificationMaintMethod(subClassificationMaint, SubClassificationMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SubClassificationMaint) null, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus NewCopy(SubClassificationMaint subClassificationMaint)
    {
      return this.NewCopy(subClassificationMaint, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus NewCopy(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      return this.NewCopy(subClassificationMaint, (SubClassificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      result = (SubClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubClassificationMaintService) this._Channel).SaveAs(this._UserProfile, subClassificationMaint, parameters, request, out result) : this.AddMethod((Method) new SubClassificationMaintMethod(subClassificationMaint, SubClassificationMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SubClassificationMaint) null, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus SaveAs(SubClassificationMaint subClassificationMaint)
    {
      return this.SaveAs(subClassificationMaint, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus SaveAs(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      return this.SaveAs(subClassificationMaint, (SubClassificationMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Parameters parameters,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      result = (SubClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubClassificationMaintService) this._Channel).UnFreeze(this._UserProfile, subClassificationMaint, parameters, request, out result) : this.AddMethod((Method) new SubClassificationMaintMethod(subClassificationMaint, SubClassificationMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) subClassificationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SubClassificationMaint) null, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus UnFreeze(SubClassificationMaint subClassificationMaint)
    {
      return this.UnFreeze(subClassificationMaint, (SubClassificationMaint_Parameters) null, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SubClassificationMaint subClassificationMaint,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      return this.UnFreeze(subClassificationMaint, (SubClassificationMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject subClassificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubClassificationMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SubClassificationMaint) subClassificationMaint, (SubClassificationMaint_Parameters) parameters, (SubClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject subClassificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubClassificationMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SubClassificationMaint) subClassificationMaint, (SubClassificationMaint_Parameters) parameters, (SubClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject subClassificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubClassificationMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SubClassificationMaint) subClassificationMaint, (SubClassificationMaint_LoadESigDetails_Parameters) parameters, (SubClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject subClassificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubClassificationMaint_Result result1;
        ResultStatus resultStatus = this.New((SubClassificationMaint) subClassificationMaint, (SubClassificationMaint_Parameters) parameters, (SubClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject subClassificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubClassificationMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SubClassificationMaint) subClassificationMaint, (SubClassificationMaint_Parameters) parameters, (SubClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject subClassificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubClassificationMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SubClassificationMaint) subClassificationMaint, (SubClassificationMaint_Parameters) parameters, (SubClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject subClassificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubClassificationMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SubClassificationMaint) subClassificationMaint, (SubClassificationMaint_Parameters) parameters, (SubClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject subClassificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubClassificationMaint_Result result1;
        ResultStatus resultStatus = this.Load((SubClassificationMaint) subClassificationMaint, (SubClassificationMaint_Parameters) parameters, (SubClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject subClassificationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SubClassificationMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SubClassificationMaint) subClassificationMaint, (SubClassificationMaint_Parameters) parameters, (SubClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      result = (SubClassificationMaint_Result) null;
      try
      {
        SubClassificationMaintMethod[] methods = new SubClassificationMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISubClassificationMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SubClassificationMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SubClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SubClassificationMaint cdo,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      result = (SubClassificationMaint_Result) null;
      try
      {
        return ((ISubClassificationMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SubClassificationMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SubClassificationMaint) cdo, (SubClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      return this.GetEnvironment((SubClassificationMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SubClassificationMaint cdo,
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      result = (SubClassificationMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISubClassificationMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SubClassificationMaintMethod(cdo, SubClassificationMaintMethods.ExecuteTransaction, (SubClassificationMaint_Parameters) null));
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
        SubClassificationMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SubClassificationMaint) cdo, (SubClassificationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SubClassificationMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SubClassificationMaint_Request) null, out SubClassificationMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SubClassificationMaint_Request request,
      out SubClassificationMaint_Result result)
    {
      return this.ExecuteTransaction((SubClassificationMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SubClassificationMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SubClassificationMaintMethod(cdo, SubClassificationMaintMethods.AddDataTransaction, (SubClassificationMaint_Parameters) null));
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
        return this.AddDataTransaction((SubClassificationMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
