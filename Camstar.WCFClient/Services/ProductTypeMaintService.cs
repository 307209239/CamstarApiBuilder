// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProductTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ProductTypeMaintService : UserCodeWithWMMaintBase
  {
    public ProductTypeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IProductTypeMaintService), userProfile);
    }

    public ResultStatus Delete(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      result = (ProductTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) productTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductTypeMaintService) this._Channel).Delete(this._UserProfile, productTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProductTypeMaintMethod(productTypeMaint, ProductTypeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) productTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ProductTypeMaint) null, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus Delete(ProductTypeMaint productTypeMaint)
    {
      return this.Delete(productTypeMaint, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus Delete(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      return this.Delete(productTypeMaint, (ProductTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      result = (ProductTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) productTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductTypeMaintService) this._Channel).Freeze(this._UserProfile, productTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProductTypeMaintMethod(productTypeMaint, ProductTypeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) productTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ProductTypeMaint) null, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus Freeze(ProductTypeMaint productTypeMaint)
    {
      return this.Freeze(productTypeMaint, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus Freeze(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      return this.Freeze(productTypeMaint, (ProductTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      result = (ProductTypeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) productTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductTypeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, productTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProductTypeMaintMethod(productTypeMaint, ProductTypeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) productTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ProductTypeMaint) null, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ProductTypeMaint productTypeMaint)
    {
      return this.GetWIPMsgs(productTypeMaint, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      return this.GetWIPMsgs(productTypeMaint, (ProductTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      result = (ProductTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) productTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductTypeMaintService) this._Channel).Load(this._UserProfile, productTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProductTypeMaintMethod(productTypeMaint, ProductTypeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) productTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ProductTypeMaint) null, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus Load(ProductTypeMaint productTypeMaint)
    {
      return this.Load(productTypeMaint, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus Load(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      return this.Load(productTypeMaint, (ProductTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_LoadESigDetails_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      result = (ProductTypeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) productTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductTypeMaintService) this._Channel).LoadESigDetails(this._UserProfile, productTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProductTypeMaintMethod(productTypeMaint, ProductTypeMaintMethods.LoadESigDetails, (ProductTypeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) productTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ProductTypeMaint) null, (ProductTypeMaint_LoadESigDetails_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ProductTypeMaint productTypeMaint)
    {
      return this.LoadESigDetails(productTypeMaint, (ProductTypeMaint_LoadESigDetails_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      return this.LoadESigDetails(productTypeMaint, (ProductTypeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      result = (ProductTypeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) productTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductTypeMaintService) this._Channel).New(this._UserProfile, productTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProductTypeMaintMethod(productTypeMaint, ProductTypeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) productTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ProductTypeMaint) null, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus New(ProductTypeMaint productTypeMaint)
    {
      return this.New(productTypeMaint, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus New(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      return this.New(productTypeMaint, (ProductTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      result = (ProductTypeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) productTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductTypeMaintService) this._Channel).NewCopy(this._UserProfile, productTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProductTypeMaintMethod(productTypeMaint, ProductTypeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) productTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ProductTypeMaint) null, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus NewCopy(ProductTypeMaint productTypeMaint)
    {
      return this.NewCopy(productTypeMaint, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus NewCopy(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      return this.NewCopy(productTypeMaint, (ProductTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      result = (ProductTypeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) productTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductTypeMaintService) this._Channel).SaveAs(this._UserProfile, productTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProductTypeMaintMethod(productTypeMaint, ProductTypeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) productTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ProductTypeMaint) null, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus SaveAs(ProductTypeMaint productTypeMaint)
    {
      return this.SaveAs(productTypeMaint, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus SaveAs(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      return this.SaveAs(productTypeMaint, (ProductTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Parameters parameters,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      result = (ProductTypeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) productTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductTypeMaintService) this._Channel).UnFreeze(this._UserProfile, productTypeMaint, parameters, request, out result) : this.AddMethod((Method) new ProductTypeMaintMethod(productTypeMaint, ProductTypeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) productTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ProductTypeMaint) null, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(ProductTypeMaint productTypeMaint)
    {
      return this.UnFreeze(productTypeMaint, (ProductTypeMaint_Parameters) null, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ProductTypeMaint productTypeMaint,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      return this.UnFreeze(productTypeMaint, (ProductTypeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject productTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductTypeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ProductTypeMaint) productTypeMaint, (ProductTypeMaint_Parameters) parameters, (ProductTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject productTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductTypeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ProductTypeMaint) productTypeMaint, (ProductTypeMaint_Parameters) parameters, (ProductTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject productTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductTypeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ProductTypeMaint) productTypeMaint, (ProductTypeMaint_LoadESigDetails_Parameters) parameters, (ProductTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject productTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductTypeMaint_Result result1;
        ResultStatus resultStatus = this.New((ProductTypeMaint) productTypeMaint, (ProductTypeMaint_Parameters) parameters, (ProductTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject productTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductTypeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ProductTypeMaint) productTypeMaint, (ProductTypeMaint_Parameters) parameters, (ProductTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject productTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductTypeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ProductTypeMaint) productTypeMaint, (ProductTypeMaint_Parameters) parameters, (ProductTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject productTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductTypeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ProductTypeMaint) productTypeMaint, (ProductTypeMaint_Parameters) parameters, (ProductTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject productTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductTypeMaint_Result result1;
        ResultStatus resultStatus = this.Load((ProductTypeMaint) productTypeMaint, (ProductTypeMaint_Parameters) parameters, (ProductTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject productTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProductTypeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ProductTypeMaint) productTypeMaint, (ProductTypeMaint_Parameters) parameters, (ProductTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      result = (ProductTypeMaint_Result) null;
      try
      {
        ProductTypeMaintMethod[] methods = new ProductTypeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IProductTypeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ProductTypeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ProductTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProductTypeMaint cdo,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      result = (ProductTypeMaint_Result) null;
      try
      {
        return ((IProductTypeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ProductTypeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ProductTypeMaint) cdo, (ProductTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      return this.GetEnvironment((ProductTypeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ProductTypeMaint cdo,
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      result = (ProductTypeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProductTypeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ProductTypeMaintMethod(cdo, ProductTypeMaintMethods.ExecuteTransaction, (ProductTypeMaint_Parameters) null));
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
        ProductTypeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ProductTypeMaint) cdo, (ProductTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ProductTypeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ProductTypeMaint_Request) null, out ProductTypeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ProductTypeMaint_Request request,
      out ProductTypeMaint_Result result)
    {
      return this.ExecuteTransaction((ProductTypeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ProductTypeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ProductTypeMaintMethod(cdo, ProductTypeMaintMethods.AddDataTransaction, (ProductTypeMaint_Parameters) null));
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
        return this.AddDataTransaction((ProductTypeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
